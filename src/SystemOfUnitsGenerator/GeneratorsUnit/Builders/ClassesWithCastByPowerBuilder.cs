using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;

namespace SystemOfUnitsGenerator.GeneratorsUnit.Builders {
    internal sealed class ClassesWithCastByPowerBuilder : IContentFileBuilderCollection {
        private readonly IEnumerable<IContentFileBuilder> _builders;

        public ClassesWithCastByPowerBuilder(IReadOnlyCollection<ContextWithCastByPower> contexts, string partialFileName) {
            IEnumerable<IContentFileBuilder> Build(ContextWithCastByPower thisContext) {
                yield return new CodeClassBuilder(thisContext);
                yield return new TestClassBuilder(thisContext);

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