using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Nanometre {
        public static implicit operator Nanometre(Exametre self) => new Nanometre(self.Value * Math.Pow(10, 27));
        public static implicit operator Nanometre(Petametre self) => new Nanometre(self.Value * Math.Pow(10, 24));
        public static implicit operator Nanometre(Terametre self) => new Nanometre(self.Value * Math.Pow(10, 21));
        public static implicit operator Nanometre(Gigametre self) => new Nanometre(self.Value * Math.Pow(10, 18));
        public static implicit operator Nanometre(Megametre self) => new Nanometre(self.Value * Math.Pow(10, 15));
        public static implicit operator Nanometre(Kilometre self) => new Nanometre(self.Value * Math.Pow(10, 12));
        public static implicit operator Nanometre(Hectometre self) => new Nanometre(self.Value * Math.Pow(10, 11));
        public static implicit operator Nanometre(Decametre self) => new Nanometre(self.Value * Math.Pow(10, 10));
        public static implicit operator Nanometre(Metre self) => new Nanometre(self.Value * Math.Pow(10, 9));
        public static implicit operator Nanometre(Decimetre self) => new Nanometre(self.Value * Math.Pow(10, 8));
        public static implicit operator Nanometre(Centimetre self) => new Nanometre(self.Value * Math.Pow(10, 7));
        public static implicit operator Nanometre(Millimetre self) => new Nanometre(self.Value * Math.Pow(10, 6));
        public static implicit operator Nanometre(Micrometre self) => new Nanometre(self.Value * Math.Pow(10, 3));
        public static implicit operator Nanometre(Picometre self) => new Nanometre(self.Value * Math.Pow(10, -3));
        public static implicit operator Nanometre(Femtometre self) => new Nanometre(self.Value * Math.Pow(10, -6));
        public static implicit operator Nanometre(Attometre self) => new Nanometre(self.Value * Math.Pow(10, -9));
    }
}
