using System;
using System.Diagnostics;

namespace SystemOfUnitsGenerator.Common {
    [DebuggerDisplay("{Name}")]
    internal struct FullQualifiedClass : IEquatable<FullQualifiedClass> {
        public FullQualifiedClass(NamespaceDefinition @namespace, ClassDefinition @class) {
            Class = @class;
            Namespace = @namespace;
            Name = $"{Namespace.Name}.{Class.Name}";
        }

        public string Name { get; }

        public NamespaceDefinition Namespace { get; }

        public ClassDefinition Class { get; }

        public bool Equals(FullQualifiedClass other) => string.Equals(Name, other.Name);

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }
            return obj is FullQualifiedClass qualified && Equals(qualified);
        }

        public override string ToString() => Name;

        public override int GetHashCode() => Name != null ? Name.GetHashCode() : 0;

        public static bool operator ==(FullQualifiedClass left, FullQualifiedClass right) => Equals(left, right);
        public static bool operator !=(FullQualifiedClass left, FullQualifiedClass right) => !Equals(left, right);

        public static implicit operator NamespaceDefinition(FullQualifiedClass self) => self.Namespace;
        public static implicit operator ClassDefinition(FullQualifiedClass self) => self.Class;
    }
}