using System;

namespace SystemOfUnits.Volume.CubicMetre {
    public partial struct CubicHectometre {
        public static implicit operator CubicHectometre(CubicKilometre self) => new CubicHectometre(self.Value * Math.Pow(10, 3));
        public static implicit operator CubicHectometre(CubicDecametre self) => new CubicHectometre(self.Value * Math.Pow(10, -3));
        public static implicit operator CubicHectometre(CubicMetre self) => new CubicHectometre(self.Value * Math.Pow(10, -6));
        public static implicit operator CubicHectometre(CubicDecimetre self) => new CubicHectometre(self.Value * Math.Pow(10, -9));
        public static implicit operator CubicHectometre(CubicCentimetre self) => new CubicHectometre(self.Value * Math.Pow(10, -12));
        public static implicit operator CubicHectometre(CubicMillimetre self) => new CubicHectometre(self.Value * Math.Pow(10, -15));
    }
}
