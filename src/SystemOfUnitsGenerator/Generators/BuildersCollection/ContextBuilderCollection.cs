using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.Builders;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.BuildersCollection {
    internal sealed class ContextBuilderCollection : IContentFileBuilderCollection {
        private readonly IEnumerable<IContentFileBuilder> _builders;

        public ContextBuilderCollection(IEnumerable<Context> contexts) {
            IEnumerable<IContentFileBuilder> Build(Context thisContext) {
                yield return new MainCodeClassBuilder(thisContext);
                yield return new MainTestClassBuilder(thisContext);
            }

            _builders = contexts.SelectMany(Build);
        }

        public IEnumerator<IContentFileBuilder> GetEnumerator() => _builders.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_builders).GetEnumerator();
    }
}