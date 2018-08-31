using System;

namespace SystemOfUnits.Volume.CubicMetre {
    public partial struct CubicDecametre {
        public static implicit operator CubicDecametre(CubicKilometre self) => new CubicDecametre(self.Value * Math.Pow(10, 6));
        public static implicit operator CubicDecametre(CubicHectometre self) => new CubicDecametre(self.Value * Math.Pow(10, 3));
        public static implicit operator CubicDecametre(CubicMetre self) => new CubicDecametre(self.Value * Math.Pow(10, -3));
        public static implicit operator CubicDecametre(CubicDecimetre self) => new CubicDecametre(self.Value * Math.Pow(10, -6));
        public static implicit operator CubicDecametre(CubicCentimetre self) => new CubicDecametre(self.Value * Math.Pow(10, -9));
        public static implicit operator CubicDecametre(CubicMillimetre self) => new CubicDecametre(self.Value * Math.Pow(10, -12));
    }
}
