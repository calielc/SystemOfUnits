using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Decametre {
        public static implicit operator Decametre(Exametre self) => new Decametre(self.Value * Math.Pow(10, 17));
        public static implicit operator Decametre(Petametre self) => new Decametre(self.Value * Math.Pow(10, 14));
        public static implicit operator Decametre(Terametre self) => new Decametre(self.Value * Math.Pow(10, 11));
        public static implicit operator Decametre(Gigametre self) => new Decametre(self.Value * Math.Pow(10, 8));
        public static implicit operator Decametre(Megametre self) => new Decametre(self.Value * Math.Pow(10, 5));
        public static implicit operator Decametre(Kilometre self) => new Decametre(self.Value * Math.Pow(10, 2));
        public static implicit operator Decametre(Hectometre self) => new Decametre(self.Value * Math.Pow(10, 1));
        public static implicit operator Decametre(Metre self) => new Decametre(self.Value * Math.Pow(10, -1));
        public static implicit operator Decametre(Decimetre self) => new Decametre(self.Value * Math.Pow(10, -2));
        public static implicit operator Decametre(Centimetre self) => new Decametre(self.Value * Math.Pow(10, -3));
        public static implicit operator Decametre(Millimetre self) => new Decametre(self.Value * Math.Pow(10, -4));
        public static implicit operator Decametre(Micrometre self) => new Decametre(self.Value * Math.Pow(10, -7));
        public static implicit operator Decametre(Nanometre self) => new Decametre(self.Value * Math.Pow(10, -10));
        public static implicit operator Decametre(Picometre self) => new Decametre(self.Value * Math.Pow(10, -13));
        public static implicit operator Decametre(Femtometre self) => new Decametre(self.Value * Math.Pow(10, -16));
        public static implicit operator Decametre(Attometre self) => new Decametre(self.Value * Math.Pow(10, -19));
    }
}
