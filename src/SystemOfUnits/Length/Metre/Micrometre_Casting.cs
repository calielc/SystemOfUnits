using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Micrometre {
        public static implicit operator Micrometre(Exametre self) => new Micrometre(self.Value * Math.Pow(10, 24));
        public static implicit operator Micrometre(Petametre self) => new Micrometre(self.Value * Math.Pow(10, 21));
        public static implicit operator Micrometre(Terametre self) => new Micrometre(self.Value * Math.Pow(10, 18));
        public static implicit operator Micrometre(Gigametre self) => new Micrometre(self.Value * Math.Pow(10, 15));
        public static implicit operator Micrometre(Megametre self) => new Micrometre(self.Value * Math.Pow(10, 12));
        public static implicit operator Micrometre(Kilometre self) => new Micrometre(self.Value * Math.Pow(10, 9));
        public static implicit operator Micrometre(Hectometre self) => new Micrometre(self.Value * Math.Pow(10, 8));
        public static implicit operator Micrometre(Decametre self) => new Micrometre(self.Value * Math.Pow(10, 7));
        public static implicit operator Micrometre(Metre self) => new Micrometre(self.Value * Math.Pow(10, 6));
        public static implicit operator Micrometre(Decimetre self) => new Micrometre(self.Value * Math.Pow(10, 5));
        public static implicit operator Micrometre(Centimetre self) => new Micrometre(self.Value * Math.Pow(10, 4));
        public static implicit operator Micrometre(Millimetre self) => new Micrometre(self.Value * Math.Pow(10, 3));
        public static implicit operator Micrometre(Nanometre self) => new Micrometre(self.Value * Math.Pow(10, -3));
        public static implicit operator Micrometre(Picometre self) => new Micrometre(self.Value * Math.Pow(10, -6));
        public static implicit operator Micrometre(Femtometre self) => new Micrometre(self.Value * Math.Pow(10, -9));
        public static implicit operator Micrometre(Attometre self) => new Micrometre(self.Value * Math.Pow(10, -12));
    }
}
