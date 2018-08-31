using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Exametre {
        public static implicit operator Exametre(Petametre self) => new Exametre(self.Value * Math.Pow(10, -3));
        public static implicit operator Exametre(Terametre self) => new Exametre(self.Value * Math.Pow(10, -6));
        public static implicit operator Exametre(Gigametre self) => new Exametre(self.Value * Math.Pow(10, -9));
        public static implicit operator Exametre(Megametre self) => new Exametre(self.Value * Math.Pow(10, -12));
        public static implicit operator Exametre(Kilometre self) => new Exametre(self.Value * Math.Pow(10, -15));
        public static implicit operator Exametre(Hectometre self) => new Exametre(self.Value * Math.Pow(10, -16));
        public static implicit operator Exametre(Decametre self) => new Exametre(self.Value * Math.Pow(10, -17));
        public static implicit operator Exametre(Metre self) => new Exametre(self.Value * Math.Pow(10, -18));
        public static implicit operator Exametre(Decimetre self) => new Exametre(self.Value * Math.Pow(10, -19));
        public static implicit operator Exametre(Centimetre self) => new Exametre(self.Value * Math.Pow(10, -20));
        public static implicit operator Exametre(Millimetre self) => new Exametre(self.Value * Math.Pow(10, -21));
        public static implicit operator Exametre(Micrometre self) => new Exametre(self.Value * Math.Pow(10, -24));
        public static implicit operator Exametre(Nanometre self) => new Exametre(self.Value * Math.Pow(10, -27));
        public static implicit operator Exametre(Picometre self) => new Exametre(self.Value * Math.Pow(10, -30));
        public static implicit operator Exametre(Femtometre self) => new Exametre(self.Value * Math.Pow(10, -33));
        public static implicit operator Exametre(Attometre self) => new Exametre(self.Value * Math.Pow(10, -36));
    }
}
