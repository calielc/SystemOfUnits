using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Gigametre {
        public static implicit operator Gigametre(Exametre self) => new Gigametre(self.Value * Math.Pow(10, 9));
        public static implicit operator Gigametre(Petametre self) => new Gigametre(self.Value * Math.Pow(10, 6));
        public static implicit operator Gigametre(Terametre self) => new Gigametre(self.Value * Math.Pow(10, 3));
        public static implicit operator Gigametre(Megametre self) => new Gigametre(self.Value * Math.Pow(10, -3));
        public static implicit operator Gigametre(Kilometre self) => new Gigametre(self.Value * Math.Pow(10, -6));
        public static implicit operator Gigametre(Hectometre self) => new Gigametre(self.Value * Math.Pow(10, -7));
        public static implicit operator Gigametre(Decametre self) => new Gigametre(self.Value * Math.Pow(10, -8));
        public static implicit operator Gigametre(Metre self) => new Gigametre(self.Value * Math.Pow(10, -9));
        public static implicit operator Gigametre(Decimetre self) => new Gigametre(self.Value * Math.Pow(10, -10));
        public static implicit operator Gigametre(Centimetre self) => new Gigametre(self.Value * Math.Pow(10, -11));
        public static implicit operator Gigametre(Millimetre self) => new Gigametre(self.Value * Math.Pow(10, -12));
        public static implicit operator Gigametre(Micrometre self) => new Gigametre(self.Value * Math.Pow(10, -15));
        public static implicit operator Gigametre(Nanometre self) => new Gigametre(self.Value * Math.Pow(10, -18));
        public static implicit operator Gigametre(Picometre self) => new Gigametre(self.Value * Math.Pow(10, -21));
        public static implicit operator Gigametre(Femtometre self) => new Gigametre(self.Value * Math.Pow(10, -24));
        public static implicit operator Gigametre(Attometre self) => new Gigametre(self.Value * Math.Pow(10, -27));
    }
}
