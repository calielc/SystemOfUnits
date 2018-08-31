using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Picometre {
        public static implicit operator Picometre(Exametre self) => new Picometre(self.Value * Math.Pow(10, 30));
        public static implicit operator Picometre(Petametre self) => new Picometre(self.Value * Math.Pow(10, 27));
        public static implicit operator Picometre(Terametre self) => new Picometre(self.Value * Math.Pow(10, 24));
        public static implicit operator Picometre(Gigametre self) => new Picometre(self.Value * Math.Pow(10, 21));
        public static implicit operator Picometre(Megametre self) => new Picometre(self.Value * Math.Pow(10, 18));
        public static implicit operator Picometre(Kilometre self) => new Picometre(self.Value * Math.Pow(10, 15));
        public static implicit operator Picometre(Hectometre self) => new Picometre(self.Value * Math.Pow(10, 14));
        public static implicit operator Picometre(Decametre self) => new Picometre(self.Value * Math.Pow(10, 13));
        public static implicit operator Picometre(Metre self) => new Picometre(self.Value * Math.Pow(10, 12));
        public static implicit operator Picometre(Decimetre self) => new Picometre(self.Value * Math.Pow(10, 11));
        public static implicit operator Picometre(Centimetre self) => new Picometre(self.Value * Math.Pow(10, 10));
        public static implicit operator Picometre(Millimetre self) => new Picometre(self.Value * Math.Pow(10, 9));
        public static implicit operator Picometre(Micrometre self) => new Picometre(self.Value * Math.Pow(10, 6));
        public static implicit operator Picometre(Nanometre self) => new Picometre(self.Value * Math.Pow(10, 3));
        public static implicit operator Picometre(Femtometre self) => new Picometre(self.Value * Math.Pow(10, -3));
        public static implicit operator Picometre(Attometre self) => new Picometre(self.Value * Math.Pow(10, -6));
    }
}
