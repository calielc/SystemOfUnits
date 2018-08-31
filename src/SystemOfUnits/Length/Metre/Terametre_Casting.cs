using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Terametre {
        public static implicit operator Terametre(Exametre self) => new Terametre(self.Value * Math.Pow(10, 6));
        public static implicit operator Terametre(Petametre self) => new Terametre(self.Value * Math.Pow(10, 3));
        public static implicit operator Terametre(Gigametre self) => new Terametre(self.Value * Math.Pow(10, -3));
        public static implicit operator Terametre(Megametre self) => new Terametre(self.Value * Math.Pow(10, -6));
        public static implicit operator Terametre(Kilometre self) => new Terametre(self.Value * Math.Pow(10, -9));
        public static implicit operator Terametre(Hectometre self) => new Terametre(self.Value * Math.Pow(10, -10));
        public static implicit operator Terametre(Decametre self) => new Terametre(self.Value * Math.Pow(10, -11));
        public static implicit operator Terametre(Metre self) => new Terametre(self.Value * Math.Pow(10, -12));
        public static implicit operator Terametre(Decimetre self) => new Terametre(self.Value * Math.Pow(10, -13));
        public static implicit operator Terametre(Centimetre self) => new Terametre(self.Value * Math.Pow(10, -14));
        public static implicit operator Terametre(Millimetre self) => new Terametre(self.Value * Math.Pow(10, -15));
        public static implicit operator Terametre(Micrometre self) => new Terametre(self.Value * Math.Pow(10, -18));
        public static implicit operator Terametre(Nanometre self) => new Terametre(self.Value * Math.Pow(10, -21));
        public static implicit operator Terametre(Picometre self) => new Terametre(self.Value * Math.Pow(10, -24));
        public static implicit operator Terametre(Femtometre self) => new Terametre(self.Value * Math.Pow(10, -27));
        public static implicit operator Terametre(Attometre self) => new Terametre(self.Value * Math.Pow(10, -30));
    }
}
