using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.Builders;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.BuildersCollection {
    internal sealed class ContextWithCastByRatioBuilderCollection : IContentFileBuilderCollection {
        private readonly IEnumerable<IContentFileBuilder> _builders;

        public ContextWithCastByRatioBuilderCollection(IReadOnlyCollection<ContextWithCastByRatio> contexts, string partialFileName) {
            IEnumerable<IContentFileBuilder> Build(ContextWithCastByRatio thisContext) {
                yield return new MainCodeClassBuilder(thisContext);
                yield return new MainTestClassBuilder(thisContext);

                var otherContexts = contexts.Where(item => !Equals(item.CodeClass, thisContext.CodeClass)).ToReadOnlyList();
                yield return new CastByRatioCodeClassBuilder(thisContext, otherContexts, partialFileName);
                yield return new CastByRatioTestClassBuilder(thisContext, otherContexts, partialFileName);
            }

            _builders = contexts.SelectMany(Build);
        }

        public IEnumerator<IContentFileBuilder> GetEnumerator() => _builders.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_builders).GetEnumerator();
    }
}