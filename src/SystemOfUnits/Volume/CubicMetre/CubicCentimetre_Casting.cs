using System;

namespace SystemOfUnits.Volume.CubicMetre {
    public partial struct CubicCentimetre {
        public static implicit operator CubicCentimetre(CubicKilometre self) => new CubicCentimetre(self.Value * Math.Pow(10, 15));
        public static implicit operator CubicCentimetre(CubicHectometre self) => new CubicCentimetre(self.Value * Math.Pow(10, 12));
        public static implicit operator CubicCentimetre(CubicDecametre self) => new CubicCentimetre(self.Value * Math.Pow(10, 9));
        public static implicit operator CubicCentimetre(CubicMetre self) => new CubicCentimetre(self.Value * Math.Pow(10, 6));
        public static implicit operator CubicCentimetre(CubicDecimetre self) => new CubicCentimetre(self.Value * Math.Pow(10, 3));
        public static implicit operator CubicCentimetre(CubicMillimetre self) => new CubicCentimetre(self.Value * Math.Pow(10, -3));
    }
}
