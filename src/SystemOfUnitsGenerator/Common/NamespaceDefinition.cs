using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SystemOfUnitsGenerator.Common {
    [DebuggerDisplay("{Name}")]
    internal struct NamespaceDefinition : IEquatable<NamespaceDefinition> {
        public static NamespaceDefinition GlogalSystem = "System";

        public static NamespaceDefinition SystemOfUnits = Resource.SystemOfUnits;
        public static NamespaceDefinition SystemOfUnitsTests = Resource.SystemOfUnits + "Tests";

        private readonly IReadOnlyCollection<string> _segments;

        private NamespaceDefinition(IEnumerable<string> segments) {
            _segments = segments.Select(segment => segment.ToCamelCase()).ToList();

            Name = string.Join(".", _segments);

            Path = string.Join("\\", _segments);
        }

        public string Name { get; }

        public string Path { get; }

        public IEnumerable<NamespaceDefinition> Levels {
            get {
                for (var take = 1; take <= _segments.Count; take++) {
                    yield return new NamespaceDefinition(_segments.Take(take));
                }
            }
        }

        public bool Equals(NamespaceDefinition other) => string.Equals(Name, other.Name);

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }
            return obj is NamespaceDefinition definition && Equals(definition);
        }

        public override string ToString() => Name;

        public override int GetHashCode() => Name != null ? Name.GetHashCode() : 0;

        public static bool operator ==(NamespaceDefinition left, NamespaceDefinition right) => Equals(left, right);

        public static bool operator !=(NamespaceDefinition left, NamespaceDefinition right) => !Equals(left, right);

        public static implicit operator NamespaceDefinition(string self) => new NamespaceDefinition(self.Split('.'));

        public static NamespaceDefinition operator +(NamespaceDefinition left, NamespaceDefinition right) => new NamespaceDefinition(left._segments.Concat(right._segments));

        public static FullQualifiedClass operator +(NamespaceDefinition left, ClassDefinition right) => new FullQualifiedClass(left, right);
    }
}