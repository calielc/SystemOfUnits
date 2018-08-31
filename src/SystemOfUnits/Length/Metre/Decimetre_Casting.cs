using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Decimetre {
        public static implicit operator Decimetre(Exametre self) => new Decimetre(self.Value * Math.Pow(10, 19));
        public static implicit operator Decimetre(Petametre self) => new Decimetre(self.Value * Math.Pow(10, 16));
        public static implicit operator Decimetre(Terametre self) => new Decimetre(self.Value * Math.Pow(10, 13));
        public static implicit operator Decimetre(Gigametre self) => new Decimetre(self.Value * Math.Pow(10, 10));
        public static implicit operator Decimetre(Megametre self) => new Decimetre(self.Value * Math.Pow(10, 7));
        public static implicit operator Decimetre(Kilometre self) => new Decimetre(self.Value * Math.Pow(10, 4));
        public static implicit operator Decimetre(Hectometre self) => new Decimetre(self.Value * Math.Pow(10, 3));
        public static implicit operator Decimetre(Decametre self) => new Decimetre(self.Value * Math.Pow(10, 2));
        public static implicit operator Decimetre(Metre self) => new Decimetre(self.Value * Math.Pow(10, 1));
        public static implicit operator Decimetre(Centimetre self) => new Decimetre(self.Value * Math.Pow(10, -1));
        public static implicit operator Decimetre(Millimetre self) => new Decimetre(self.Value * Math.Pow(10, -2));
        public static implicit operator Decimetre(Micrometre self) => new Decimetre(self.Value * Math.Pow(10, -5));
        public static implicit operator Decimetre(Nanometre self) => new Decimetre(self.Value * Math.Pow(10, -8));
        public static implicit operator Decimetre(Picometre self) => new Decimetre(self.Value * Math.Pow(10, -11));
        public static implicit operator Decimetre(Femtometre self) => new Decimetre(self.Value * Math.Pow(10, -14));
        public static implicit operator Decimetre(Attometre self) => new Decimetre(self.Value * Math.Pow(10, -17));
    }
}
