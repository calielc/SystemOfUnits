using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.Builders {
    [DebuggerDisplay("Test {PartialFileName}: {ThisContext.Symbol}")]
    internal sealed class CastByRatioTestClassBuilder : IContentFileBuilder {
        public CastByRatioTestClassBuilder(ContextWithCastByRatio thisContext, IReadOnlyList<ContextWithCastByRatio> otherContexts, string partialFileName) {
            ThisContext = thisContext;
            PartialFileName = partialFileName;
            OtherContexts = otherContexts;
        }

        public ContextWithCastByRatio ThisContext { get; }
        public IReadOnlyList<ContextWithCastByRatio> OtherContexts { get; }
        public string PartialFileName { get; }

        public IContentFile BuildFile() {
            var contentBuilder = new StringBuilder();

            contentBuilder.AppendLine("using NUnit.Framework;");
            contentBuilder.AppendLine();
            contentBuilder.AppendLine($"namespace {ThisContext.TestClass.Namespace.Name} {{");
            contentBuilder.AppendLine($"    using {ThisContext.CodeClass.Class} = {ThisContext.CodeClass};");
            contentBuilder.AppendLine();
            contentBuilder.AppendLine($"    partial class {ThisContext.TestClass.Class.Name} {{");

            for (var idxOther = 0; idxOther < OtherContexts.Count; idxOther++) {
                var otherContext = OtherContexts[idxOther];

                if (idxOther > 0) {
                    contentBuilder.AppendLine();
                }

                foreach (var testCase in ThisContext.TestCases) {
                    contentBuilder.AppendLine($"        [TestCase({testCase.Inputs[idxOther]}d, {testCase.Expected}d)]");
                }

                contentBuilder.AppendLine(string.Format(
@"        public void Should_cast_from_{0}(double {1}Value, double expectedValue) {{
            var {1}Instance = new {3}({1}Value);

            {2} actual = {1}Instance;
            Assert.IsAssignableFrom<{2}>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }}",
                    otherContext.CodeClass.Class.Name,
                    otherContext.CodeClass.Class.Instance,
                    ThisContext.CodeClass.Class,
                    otherContext.CodeClass));
            }

            contentBuilder.AppendLine("    }");
            contentBuilder.AppendLine("}");

            return new CSharpPartialFile(ThisContext.TestClass, PartialFileName, contentBuilder.ToString());
        }
    }
}