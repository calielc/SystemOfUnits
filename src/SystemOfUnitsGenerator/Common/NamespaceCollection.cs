using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SystemOfUnitsGenerator.Common {
    internal sealed class NamespaceCollection : IReadOnlyCollection<NamespaceDefinition> {
        private List<NamespaceDefinition> _list = new List<NamespaceDefinition>();

        public int Count => _list.Count;

        public NamespaceCollection Add(NamespaceDefinition item) {
            SetItems(_list.Concat(new[] { item }));

            return this;
        }

        public NamespaceCollection Add(IEnumerable<NamespaceDefinition> items) {
            SetItems(_list.Concat(items));

            return this;
        }

        public NamespaceCollection Except(NamespaceDefinition item) {
            SetItems(_list.Except(new[] { item }));

            return this;
        }

        public NamespaceCollection Except(IEnumerable<NamespaceDefinition> items) {
            SetItems(_list.Except(items));

            return this;
        }

        private void SetItems(IEnumerable<NamespaceDefinition> items) {
            _list = items
                .Distinct()
                .OrderBy(item => {
                    if (item.Name.Equals("System")) {
                        return 0;
                    }
                    return item.Name.StartsWith("System.") ? 1 : 2;
                })
                .ThenBy(item => item.Name)
                .ToList();
        }

        public IEnumerator<NamespaceDefinition> GetEnumerator() => _list.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_list).GetEnumerator();
    }
}