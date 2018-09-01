using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;

namespace SystemOfUnitsGenerator.GeneratorsCurrency.Builders {
    internal sealed class ClassesBuilder : IContentFileBuilderCollection {
        private readonly IEnumerable<IContentFileBuilder> _builders;

        public ClassesBuilder(IEnumerable<Context> contexts) {
            IEnumerable<IContentFileBuilder> Build(Context thisContext) {
                yield return new CodeClassBuilder(thisContext);
                yield return new TestClassBuilder(thisContext);
            }

            _builders = contexts.SelectMany(Build);
        }

        public IEnumerator<IContentFileBuilder> GetEnumerator() => _builders.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_builders).GetEnumerator();
    }
}