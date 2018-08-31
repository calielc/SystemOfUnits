using System.Diagnostics;
using System.Linq;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.Engine;
using SystemOfUnitsGenerator.Generators.Templates;

namespace SystemOfUnitsGenerator.Generators.Builders {
    [DebuggerDisplay("Test: {Context.Symbol}")]
    internal sealed class MainTestClassBuilder : IContentFileBuilder {
        public MainTestClassBuilder(IContext context) {
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