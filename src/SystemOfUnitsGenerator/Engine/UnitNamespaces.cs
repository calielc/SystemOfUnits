using System.Diagnostics;
using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Engine {
    [DebuggerDisplay("{Code} X {Test}")]
    internal struct UnitNamespaces {
        public UnitNamespaces(string unit) {
            Code = NamespaceDefinition.SystemOfUnits + unit;
            Test = NamespaceDefinition.SystemOfUnitsTests + unit;
        }

        public NamespaceDefinition Code { get; }
        public NamespaceDefinition Test { get; }
    }
}