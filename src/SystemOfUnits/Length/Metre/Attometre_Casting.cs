using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Attometre {
        public static implicit operator Attometre(Exametre self) => new Attometre(self.Value * Math.Pow(10, 36));
        public static implicit operator Attometre(Petametre self) => new Attometre(self.Value * Math.Pow(10, 33));
        public static implicit operator Attometre(Terametre self) => new Attometre(self.Value * Math.Pow(10, 30));
        public static implicit operator Attometre(Gigametre self) => new Attometre(self.Value * Math.Pow(10, 27));
        public static implicit operator Attometre(Megametre self) => new Attometre(self.Value * Math.Pow(10, 24));
        public static implicit operator Attometre(Kilometre self) => new Attometre(self.Value * Math.Pow(10, 21));
        public static implicit operator Attometre(Hectometre self) => new Attometre(self.Value * Math.Pow(10, 20));
        public static implicit operator Attometre(Decametre self) => new Attometre(self.Value * Math.Pow(10, 19));
        public static implicit operator Attometre(Metre self) => new Attometre(self.Value * Math.Pow(10, 18));
        public static implicit operator Attometre(Decimetre self) => new Attometre(self.Value * Math.Pow(10, 17));
        public static implicit operator Attometre(Centimetre self) => new Attometre(self.Value * Math.Pow(10, 16));
        public static implicit operator Attometre(Millimetre self) => new Attometre(self.Value * Math.Pow(10, 15));
        public static implicit operator Attometre(Micrometre self) => new Attometre(self.Value * Math.Pow(10, 12));
        public static implicit operator Attometre(Nanometre self) => new Attometre(self.Value * Math.Pow(10, 9));
        public static implicit operator Attometre(Picometre self) => new Attometre(self.Value * Math.Pow(10, 6));
        public static implicit operator Attometre(Femtometre self) => new Attometre(self.Value * Math.Pow(10, 3));
    }
}
