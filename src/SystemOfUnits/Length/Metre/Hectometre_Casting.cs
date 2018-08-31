using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Hectometre {
        public static implicit operator Hectometre(Exametre self) => new Hectometre(self.Value * Math.Pow(10, 16));
        public static implicit operator Hectometre(Petametre self) => new Hectometre(self.Value * Math.Pow(10, 13));
        public static implicit operator Hectometre(Terametre self) => new Hectometre(self.Value * Math.Pow(10, 10));
        public static implicit operator Hectometre(Gigametre self) => new Hectometre(self.Value * Math.Pow(10, 7));
        public static implicit operator Hectometre(Megametre self) => new Hectometre(self.Value * Math.Pow(10, 4));
        public static implicit operator Hectometre(Kilometre self) => new Hectometre(self.Value * Math.Pow(10, 1));
        public static implicit operator Hectometre(Decametre self) => new Hectometre(self.Value * Math.Pow(10, -1));
        public static implicit operator Hectometre(Metre self) => new Hectometre(self.Value * Math.Pow(10, -2));
        public static implicit operator Hectometre(Decimetre self) => new Hectometre(self.Value * Math.Pow(10, -3));
        public static implicit operator Hectometre(Centimetre self) => new Hectometre(self.Value * Math.Pow(10, -4));
        public static implicit operator Hectometre(Millimetre self) => new Hectometre(self.Value * Math.Pow(10, -5));
        public static implicit operator Hectometre(Micrometre self) => new Hectometre(self.Value * Math.Pow(10, -8));
        public static implicit operator Hectometre(Nanometre self) => new Hectometre(self.Value * Math.Pow(10, -11));
        public static implicit operator Hectometre(Picometre self) => new Hectometre(self.Value * Math.Pow(10, -14));
        public static implicit operator Hectometre(Femtometre self) => new Hectometre(self.Value * Math.Pow(10, -17));
        public static implicit operator Hectometre(Attometre self) => new Hectometre(self.Value * Math.Pow(10, -20));
    }
}
