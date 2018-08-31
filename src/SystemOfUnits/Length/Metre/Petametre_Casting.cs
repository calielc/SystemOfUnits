using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Petametre {
        public static implicit operator Petametre(Exametre self) => new Petametre(self.Value * Math.Pow(10, 3));
        public static implicit operator Petametre(Terametre self) => new Petametre(self.Value * Math.Pow(10, -3));
        public static implicit operator Petametre(Gigametre self) => new Petametre(self.Value * Math.Pow(10, -6));
        public static implicit operator Petametre(Megametre self) => new Petametre(self.Value * Math.Pow(10, -9));
        public static implicit operator Petametre(Kilometre self) => new Petametre(self.Value * Math.Pow(10, -12));
        public static implicit operator Petametre(Hectometre self) => new Petametre(self.Value * Math.Pow(10, -13));
        public static implicit operator Petametre(Decametre self) => new Petametre(self.Value * Math.Pow(10, -14));
        public static implicit operator Petametre(Metre self) => new Petametre(self.Value * Math.Pow(10, -15));
        public static implicit operator Petametre(Decimetre self) => new Petametre(self.Value * Math.Pow(10, -16));
        public static implicit operator Petametre(Centimetre self) => new Petametre(self.Value * Math.Pow(10, -17));
        public static implicit operator Petametre(Millimetre self) => new Petametre(self.Value * Math.Pow(10, -18));
        public static implicit operator Petametre(Micrometre self) => new Petametre(self.Value * Math.Pow(10, -21));
        public static implicit operator Petametre(Nanometre self) => new Petametre(self.Value * Math.Pow(10, -24));
        public static implicit operator Petametre(Picometre self) => new Petametre(self.Value * Math.Pow(10, -27));
        public static implicit operator Petametre(Femtometre self) => new Petametre(self.Value * Math.Pow(10, -30));
        public static implicit operator Petametre(Attometre self) => new Petametre(self.Value * Math.Pow(10, -33));
    }
}
