using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Megametre {
        public static implicit operator Megametre(Exametre self) => new Megametre(self.Value * Math.Pow(10, 12));
        public static implicit operator Megametre(Petametre self) => new Megametre(self.Value * Math.Pow(10, 9));
        public static implicit operator Megametre(Terametre self) => new Megametre(self.Value * Math.Pow(10, 6));
        public static implicit operator Megametre(Gigametre self) => new Megametre(self.Value * Math.Pow(10, 3));
        public static implicit operator Megametre(Kilometre self) => new Megametre(self.Value * Math.Pow(10, -3));
        public static implicit operator Megametre(Hectometre self) => new Megametre(self.Value * Math.Pow(10, -4));
        public static implicit operator Megametre(Decametre self) => new Megametre(self.Value * Math.Pow(10, -5));
        public static implicit operator Megametre(Metre self) => new Megametre(self.Value * Math.Pow(10, -6));
        public static implicit operator Megametre(Decimetre self) => new Megametre(self.Value * Math.Pow(10, -7));
        public static implicit operator Megametre(Centimetre self) => new Megametre(self.Value * Math.Pow(10, -8));
        public static implicit operator Megametre(Millimetre self) => new Megametre(self.Value * Math.Pow(10, -9));
        public static implicit operator Megametre(Micrometre self) => new Megametre(self.Value * Math.Pow(10, -12));
        public static implicit operator Megametre(Nanometre self) => new Megametre(self.Value * Math.Pow(10, -15));
        public static implicit operator Megametre(Picometre self) => new Megametre(self.Value * Math.Pow(10, -18));
        public static implicit operator Megametre(Femtometre self) => new Megametre(self.Value * Math.Pow(10, -21));
        public static implicit operator Megametre(Attometre self) => new Megametre(self.Value * Math.Pow(10, -24));
    }
}
