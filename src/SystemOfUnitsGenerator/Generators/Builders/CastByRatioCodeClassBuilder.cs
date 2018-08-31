using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.Builders {
    [DebuggerDisplay("Code {PartialFileName}: {Symbol}")]
    internal sealed class CastByRatioCodeClassBuilder : IContentFileBuilder {
        public CastByRatioCodeClassBuilder(ContextWithCastByRatio thisContext, IEnumerable<ContextWithCastByRatio> otherContexts, string partialFileName) {
            ThisContext = thisContext;
            OtherContexts = otherContexts;
            PartialFileName = partialFileName;
        }

        public ContextWithCastByRatio ThisContext { get; }
        public IEnumerable<ContextWithCastByRatio> OtherContexts { get; }
        public string PartialFileName { get; }

        public IContentFile BuildFile() {
            var contentBuilder = new StringBuilder();

            contentBuilder.AppendLine($"namespace {ThisContext.CodeClass.Namespace.Name} {{");
            contentBuilder.AppendLine($"    public partial struct {ThisContext.CodeClass.Class.Name} {{");

            if (ThisContext.Ratio.NumericalValue != 1) {
                contentBuilder.AppendLine(
                    $"        internal const double {ThisContext.Ratio.ConstantName} = {ThisContext.Ratio.CSharpValue};");
                contentBuilder.AppendLine();
            }

            foreach (var otherContext in OtherContexts) {
                string MathematicalExpression() {
                    if (otherContext.Ratio.NumericalValue == ThisContext.Ratio.NumericalValue) {
                        return "self.Value";
                    }

                    if (ThisContext.Ratio.NumericalValue == 1) {
                        return $"self.Value * {otherContext.CodeClass.Class}.{otherContext.Ratio.ConstantName}";
                    }

                    if (otherContext.Ratio.NumericalValue == 1) {
                        return $"self.Value / {ThisContext.Ratio.ConstantName}";
                    }

                    return $"self.Value * {otherContext.CodeClass.Class}.{otherContext.Ratio.ConstantName} / {ThisContext.Ratio.ConstantName}";
                }

                contentBuilder.AppendLine(string.Format(
                    "        public static implicit operator {0}({1} self) => new {0}({2});",
                    ThisContext.CodeClass.Class,
                    otherContext.CodeClass.Class,
                    MathematicalExpression()
                ));
            }

            contentBuilder.AppendLine("    }");
            contentBuilder.AppendLine("}");

            return new CSharpPartialFile(ThisContext.CodeClass, PartialFileName, contentBuilder.ToString());
        }
    }
}