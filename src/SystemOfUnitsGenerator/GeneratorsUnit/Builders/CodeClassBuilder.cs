using System.Diagnostics;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.GeneratorsUnit.Templates;

namespace SystemOfUnitsGenerator.GeneratorsUnit.Builders {
    [DebuggerDisplay("Code: {Symbol}")]
    internal sealed class CodeClassBuilder : IContentFileBuilder {
        public CodeClassBuilder(IContext context) {
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