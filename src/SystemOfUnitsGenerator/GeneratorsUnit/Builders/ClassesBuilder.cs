using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;

namespace SystemOfUnitsGenerator.GeneratorsUnit.Builders {
    internal sealed class ClassesBuilder : IContentFileBuilderCollection {
        private readonly IEnumerable<IContentFileBuilder> _builders;

        public ClassesBuilder(IEnumerable<IContext> contexts) {
            IEnumerable<IContentFileBuilder> Build(IContext thisContext) {
                yield return new CodeClassBuilder(thisContext);
                yield return new TestClassBuilder(thisContext);
            }

            _builders = contexts.SelectMany(Build);
        }

        public IEnumerator<IContentFileBuilder> GetEnumerator() => _builders.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_builders).GetEnumerator();
    }
}