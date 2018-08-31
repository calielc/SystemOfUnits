using System;

namespace SystemOfUnits.Volume.CubicMetre {
    public partial struct CubicKilometre {
        public static implicit operator CubicKilometre(CubicHectometre self) => new CubicKilometre(self.Value * Math.Pow(10, -3));
        public static implicit operator CubicKilometre(CubicDecametre self) => new CubicKilometre(self.Value * Math.Pow(10, -6));
        public static implicit operator CubicKilometre(CubicMetre self) => new CubicKilometre(self.Value * Math.Pow(10, -9));
        public static implicit operator CubicKilometre(CubicDecimetre self) => new CubicKilometre(self.Value * Math.Pow(10, -12));
        public static implicit operator CubicKilometre(CubicCentimetre self) => new CubicKilometre(self.Value * Math.Pow(10, -15));
        public static implicit operator CubicKilometre(CubicMillimetre self) => new CubicKilometre(self.Value * Math.Pow(10, -18));
    }
}
