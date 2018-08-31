using System;

namespace SystemOfUnits.Volume.CubicMetre {
    public partial struct CubicDecimetre {
        public static implicit operator CubicDecimetre(CubicKilometre self) => new CubicDecimetre(self.Value * Math.Pow(10, 12));
        public static implicit operator CubicDecimetre(CubicHectometre self) => new CubicDecimetre(self.Value * Math.Pow(10, 9));
        public static implicit operator CubicDecimetre(CubicDecametre self) => new CubicDecimetre(self.Value * Math.Pow(10, 6));
        public static implicit operator CubicDecimetre(CubicMetre self) => new CubicDecimetre(self.Value * Math.Pow(10, 3));
        public static implicit operator CubicDecimetre(CubicCentimetre self) => new CubicDecimetre(self.Value * Math.Pow(10, -3));
        public static implicit operator CubicDecimetre(CubicMillimetre self) => new CubicDecimetre(self.Value * Math.Pow(10, -6));
    }
}
