using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Millimetre {
        public static implicit operator Millimetre(Exametre self) => new Millimetre(self.Value * Math.Pow(10, 21));
        public static implicit operator Millimetre(Petametre self) => new Millimetre(self.Value * Math.Pow(10, 18));
        public static implicit operator Millimetre(Terametre self) => new Millimetre(self.Value * Math.Pow(10, 15));
        public static implicit operator Millimetre(Gigametre self) => new Millimetre(self.Value * Math.Pow(10, 12));
        public static implicit operator Millimetre(Megametre self) => new Millimetre(self.Value * Math.Pow(10, 9));
        public static implicit operator Millimetre(Kilometre self) => new Millimetre(self.Value * Math.Pow(10, 6));
        public static implicit operator Millimetre(Hectometre self) => new Millimetre(self.Value * Math.Pow(10, 5));
        public static implicit operator Millimetre(Decametre self) => new Millimetre(self.Value * Math.Pow(10, 4));
        public static implicit operator Millimetre(Metre self) => new Millimetre(self.Value * Math.Pow(10, 3));
        public static implicit operator Millimetre(Decimetre self) => new Millimetre(self.Value * Math.Pow(10, 2));
        public static implicit operator Millimetre(Centimetre self) => new Millimetre(self.Value * Math.Pow(10, 1));
        public static implicit operator Millimetre(Micrometre self) => new Millimetre(self.Value * Math.Pow(10, -3));
        public static implicit operator Millimetre(Nanometre self) => new Millimetre(self.Value * Math.Pow(10, -6));
        public static implicit operator Millimetre(Picometre self) => new Millimetre(self.Value * Math.Pow(10, -9));
        public static implicit operator Millimetre(Femtometre self) => new Millimetre(self.Value * Math.Pow(10, -12));
        public static implicit operator Millimetre(Attometre self) => new Millimetre(self.Value * Math.Pow(10, -15));
    }
}
