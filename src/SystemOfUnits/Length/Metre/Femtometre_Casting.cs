using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Femtometre {
        public static implicit operator Femtometre(Exametre self) => new Femtometre(self.Value * Math.Pow(10, 33));
        public static implicit operator Femtometre(Petametre self) => new Femtometre(self.Value * Math.Pow(10, 30));
        public static implicit operator Femtometre(Terametre self) => new Femtometre(self.Value * Math.Pow(10, 27));
        public static implicit operator Femtometre(Gigametre self) => new Femtometre(self.Value * Math.Pow(10, 24));
        public static implicit operator Femtometre(Megametre self) => new Femtometre(self.Value * Math.Pow(10, 21));
        public static implicit operator Femtometre(Kilometre self) => new Femtometre(self.Value * Math.Pow(10, 18));
        public static implicit operator Femtometre(Hectometre self) => new Femtometre(self.Value * Math.Pow(10, 17));
        public static implicit operator Femtometre(Decametre self) => new Femtometre(self.Value * Math.Pow(10, 16));
        public static implicit operator Femtometre(Metre self) => new Femtometre(self.Value * Math.Pow(10, 15));
        public static implicit operator Femtometre(Decimetre self) => new Femtometre(self.Value * Math.Pow(10, 14));
        public static implicit operator Femtometre(Centimetre self) => new Femtometre(self.Value * Math.Pow(10, 13));
        public static implicit operator Femtometre(Millimetre self) => new Femtometre(self.Value * Math.Pow(10, 12));
        public static implicit operator Femtometre(Micrometre self) => new Femtometre(self.Value * Math.Pow(10, 9));
        public static implicit operator Femtometre(Nanometre self) => new Femtometre(self.Value * Math.Pow(10, 6));
        public static implicit operator Femtometre(Picometre self) => new Femtometre(self.Value * Math.Pow(10, 3));
        public static implicit operator Femtometre(Attometre self) => new Femtometre(self.Value * Math.Pow(10, -3));
    }
}
