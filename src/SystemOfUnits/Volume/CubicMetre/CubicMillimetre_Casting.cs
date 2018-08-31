using System;

namespace SystemOfUnits.Volume.CubicMetre {
    public partial struct CubicMillimetre {
        public static implicit operator CubicMillimetre(CubicKilometre self) => new CubicMillimetre(self.Value * Math.Pow(10, 18));
        public static implicit operator CubicMillimetre(CubicHectometre self) => new CubicMillimetre(self.Value * Math.Pow(10, 15));
        public static implicit operator CubicMillimetre(CubicDecametre self) => new CubicMillimetre(self.Value * Math.Pow(10, 12));
        public static implicit operator CubicMillimetre(CubicMetre self) => new CubicMillimetre(self.Value * Math.Pow(10, 9));
        public static implicit operator CubicMillimetre(CubicDecimetre self) => new CubicMillimetre(self.Value * Math.Pow(10, 6));
        public static implicit operator CubicMillimetre(CubicCentimetre self) => new CubicMillimetre(self.Value * Math.Pow(10, 3));
    }
}
