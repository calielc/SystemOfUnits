using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.Builders;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.BuildersCollection {
    internal sealed class ContextWithCastByPowerBuilderCollection : IContentFileBuilderCollection {
        private readonly IEnumerable<IContentFileBuilder> _builders;

        public ContextWithCastByPowerBuilderCollection(IReadOnlyCollection<ContextWithCastByPower> contexts, string partialFileName) {
            IEnumerable<IContentFileBuilder> Build(ContextWithCastByPower thisContext) {
                yield return new MainCodeClassBuilder(thisContext);
                yield return new MainTestClassBuilder(thisContext);

                var otherContexts = contexts.Where(item => !Equals(item.CodeClass, thisContext.CodeClass)).ToReadOnlyList();
                yield return new CastByPowerCodeClassBuilder(thisContext, otherContexts, partialFileName);
                yield return new CastByPowerTestClassBuilder(thisContext, otherContexts, partialFileName);
            }

            _builders = contexts.SelectMany(Build);

        }

        public IEnumerator<IContentFileBuilder> GetEnumerator() => _builders.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_builders).GetEnumerator();
    }
}