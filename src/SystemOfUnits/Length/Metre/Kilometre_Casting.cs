using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Kilometre {
        public static implicit operator Kilometre(Exametre self) => new Kilometre(self.Value * Math.Pow(10, 15));
        public static implicit operator Kilometre(Petametre self) => new Kilometre(self.Value * Math.Pow(10, 12));
        public static implicit operator Kilometre(Terametre self) => new Kilometre(self.Value * Math.Pow(10, 9));
        public static implicit operator Kilometre(Gigametre self) => new Kilometre(self.Value * Math.Pow(10, 6));
        public static implicit operator Kilometre(Megametre self) => new Kilometre(self.Value * Math.Pow(10, 3));
        public static implicit operator Kilometre(Hectometre self) => new Kilometre(self.Value * Math.Pow(10, -1));
        public static implicit operator Kilometre(Decametre self) => new Kilometre(self.Value * Math.Pow(10, -2));
        public static implicit operator Kilometre(Metre self) => new Kilometre(self.Value * Math.Pow(10, -3));
        public static implicit operator Kilometre(Decimetre self) => new Kilometre(self.Value * Math.Pow(10, -4));
        public static implicit operator Kilometre(Centimetre self) => new Kilometre(self.Value * Math.Pow(10, -5));
        public static implicit operator Kilometre(Millimetre self) => new Kilometre(self.Value * Math.Pow(10, -6));
        public static implicit operator Kilometre(Micrometre self) => new Kilometre(self.Value * Math.Pow(10, -9));
        public static implicit operator Kilometre(Nanometre self) => new Kilometre(self.Value * Math.Pow(10, -12));
        public static implicit operator Kilometre(Picometre self) => new Kilometre(self.Value * Math.Pow(10, -15));
        public static implicit operator Kilometre(Femtometre self) => new Kilometre(self.Value * Math.Pow(10, -18));
        public static implicit operator Kilometre(Attometre self) => new Kilometre(self.Value * Math.Pow(10, -21));
    }
}
