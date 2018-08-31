using System;
using System.Diagnostics;
using System.Linq;

namespace SystemOfUnitsGenerator.Common {
    [DebuggerDisplay("{Name}")]
    internal struct ClassDefinition : IEquatable<ClassDefinition> {
        public ClassDefinition(string name) {
            var parts = name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(part => part.ToCamelCase());

            Name = string.Join("", parts);
            Instance = Name.ToLowerCamelCase();
        }

        public string Name { get; }

        public string Instance { get; }

        public bool Equals(ClassDefinition other) => string.Equals(Name, other.Name);

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }
            return obj is ClassDefinition definition && Equals(definition);
        }

        public override string ToString() => Name;

        public override int GetHashCode() => Name != null ? Name.GetHashCode() : 0;

        public static bool operator ==(ClassDefinition left, ClassDefinition right) => Equals(left, right);
        public static bool operator !=(ClassDefinition left, ClassDefinition right) => !Equals(left, right);

        public static explicit operator ClassDefinition(string self) => new ClassDefinition(self);
    }
}