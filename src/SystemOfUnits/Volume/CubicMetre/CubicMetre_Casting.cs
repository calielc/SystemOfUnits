using System;

namespace SystemOfUnits.Volume.CubicMetre {
    public partial struct CubicMetre {
        public static implicit operator CubicMetre(CubicKilometre self) => new CubicMetre(self.Value * Math.Pow(10, 9));
        public static implicit operator CubicMetre(CubicHectometre self) => new CubicMetre(self.Value * Math.Pow(10, 6));
        public static implicit operator CubicMetre(CubicDecametre self) => new CubicMetre(self.Value * Math.Pow(10, 3));
        public static implicit operator CubicMetre(CubicDecimetre self) => new CubicMetre(self.Value * Math.Pow(10, -3));
        public static implicit operator CubicMetre(CubicCentimetre self) => new CubicMetre(self.Value * Math.Pow(10, -6));
        public static implicit operator CubicMetre(CubicMillimetre self) => new CubicMetre(self.Value * Math.Pow(10, -9));
    }
}
