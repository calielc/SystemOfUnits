using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Centimetre {
        public static implicit operator Centimetre(Exametre self) => new Centimetre(self.Value * Math.Pow(10, 20));
        public static implicit operator Centimetre(Petametre self) => new Centimetre(self.Value * Math.Pow(10, 17));
        public static implicit operator Centimetre(Terametre self) => new Centimetre(self.Value * Math.Pow(10, 14));
        public static implicit operator Centimetre(Gigametre self) => new Centimetre(self.Value * Math.Pow(10, 11));
        public static implicit operator Centimetre(Megametre self) => new Centimetre(self.Value * Math.Pow(10, 8));
        public static implicit operator Centimetre(Kilometre self) => new Centimetre(self.Value * Math.Pow(10, 5));
        public static implicit operator Centimetre(Hectometre self) => new Centimetre(self.Value * Math.Pow(10, 4));
        public static implicit operator Centimetre(Decametre self) => new Centimetre(self.Value * Math.Pow(10, 3));
        public static implicit operator Centimetre(Metre self) => new Centimetre(self.Value * Math.Pow(10, 2));
        public static implicit operator Centimetre(Decimetre self) => new Centimetre(self.Value * Math.Pow(10, 1));
        public static implicit operator Centimetre(Millimetre self) => new Centimetre(self.Value * Math.Pow(10, -1));
        public static implicit operator Centimetre(Micrometre self) => new Centimetre(self.Value * Math.Pow(10, -4));
        public static implicit operator Centimetre(Nanometre self) => new Centimetre(self.Value * Math.Pow(10, -7));
        public static implicit operator Centimetre(Picometre self) => new Centimetre(self.Value * Math.Pow(10, -10));
        public static implicit operator Centimetre(Femtometre self) => new Centimetre(self.Value * Math.Pow(10, -13));
        public static implicit operator Centimetre(Attometre self) => new Centimetre(self.Value * Math.Pow(10, -16));
    }
}
