using System.Diagnostics;
using System.Linq;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.GeneratorsUnit.Templates;

namespace SystemOfUnitsGenerator.GeneratorsUnit.Builders {
    [DebuggerDisplay("Test: {Context.Symbol}")]
    internal sealed class TestClassBuilder : IContentFileBuilder {
        public TestClassBuilder(IContext context) {
            Context = context;
        }

        public IContext Context { get; }

        public IContentFile BuildFile() {
            var template = new TestClassTemplate {
                CodeClass = Context.CodeClass,
                TestClass = Context.TestClass,

                Symbol = Context.Symbol,
            };
            template.UsingNamespaces
                .Add(Context.CodeClass.Namespace.Levels.First())
                .Except(Context.TestClass.Namespace);

            return new CSharpFile(Context.TestClass, template.TransformText());
        }
    }
}