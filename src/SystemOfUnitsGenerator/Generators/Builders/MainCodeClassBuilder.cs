using System.Diagnostics;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.Engine;
using SystemOfUnitsGenerator.Generators.Templates;

namespace SystemOfUnitsGenerator.Generators.Builders {
    [DebuggerDisplay("Code: {Symbol}")]
    internal sealed class MainCodeClassBuilder : IContentFileBuilder {
        public MainCodeClassBuilder(IContext context) {
            CodeClass = context.CodeClass;
            Symbol = context.Symbol;
            XmlDoc = context.XmlDoc;
        }

        public FullQualifiedClass CodeClass { get; }
        public string Symbol { get; }
        public XmlDoc XmlDoc { get; }

        public IContentFile BuildFile() {
            var template = new CodeClassTemplate {
                Namespace = CodeClass.Namespace.Name,
                ClassName = CodeClass.Class.Name,

                Symbol = Symbol,
                XmlDoc = XmlDoc,
            };

            return new CSharpFile(CodeClass, template.TransformText());
        }
    }
}