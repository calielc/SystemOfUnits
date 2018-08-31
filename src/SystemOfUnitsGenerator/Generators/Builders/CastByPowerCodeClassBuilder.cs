using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.Builders {
    [DebuggerDisplay("Code {PartialFileName}: {Symbol}")]
    internal sealed class CastByPowerCodeClassBuilder : IContentFileBuilder {
        public CastByPowerCodeClassBuilder(ContextWithCastByPower thisContext, IEnumerable<ContextWithCastByPower> otherContexts, string partialFileName) {
            ThisContext = thisContext;
            OtherContexts = otherContexts;
            PartialFileName = partialFileName;
        }

        public ContextWithCastByPower ThisContext { get; }
        public IEnumerable<ContextWithCastByPower> OtherContexts { get; }
        public string PartialFileName { get; }

        public IContentFile BuildFile() {
            var contentBuilder = new StringBuilder();

            contentBuilder.AppendLine("using System;");
            contentBuilder.AppendLine();
            contentBuilder.AppendLine($"namespace {ThisContext.CodeClass.Namespace.Name} {{");
            contentBuilder.AppendLine($"    public partial struct {ThisContext.CodeClass.Class.Name} {{");

            foreach (var otherContext in OtherContexts) {
                string MathematicalExpression() {
                    if (otherContext.Power.BaseNumber == ThisContext.Power.BaseNumber &&
                        otherContext.Power.Exponent == ThisContext.Power.Exponent) {
                        return "self.value";
                    }

                    if (otherContext.Power.BaseNumber == ThisContext.Power.BaseNumber &&
                        otherContext.Power.Exponent != ThisContext.Power.Exponent) {
                        return $"self.Value * Math.Pow({ThisContext.Power.BaseNumber}, {otherContext.Power.Exponent - ThisContext.Power.Exponent})";
                    }

                    throw new Exception();
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