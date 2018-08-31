using System;

namespace SystemOfUnits.Length.Metre {
    public partial struct Metre {
        public static implicit operator Metre(Exametre self) => new Metre(self.Value * Math.Pow(10, 18));
        public static implicit operator Metre(Petametre self) => new Metre(self.Value * Math.Pow(10, 15));
        public static implicit operator Metre(Terametre self) => new Metre(self.Value * Math.Pow(10, 12));
        public static implicit operator Metre(Gigametre self) => new Metre(self.Value * Math.Pow(10, 9));
        public static implicit operator Metre(Megametre self) => new Metre(self.Value * Math.Pow(10, 6));
        public static implicit operator Metre(Kilometre self) => new Metre(self.Value * Math.Pow(10, 3));
        public static implicit operator Metre(Hectometre self) => new Metre(self.Value * Math.Pow(10, 2));
        public static implicit operator Metre(Decametre self) => new Metre(self.Value * Math.Pow(10, 1));
        public static implicit operator Metre(Decimetre self) => new Metre(self.Value * Math.Pow(10, -1));
        public static implicit operator Metre(Centimetre self) => new Metre(self.Value * Math.Pow(10, -2));
        public static implicit operator Metre(Millimetre self) => new Metre(self.Value * Math.Pow(10, -3));
        public static implicit operator Metre(Micrometre self) => new Metre(self.Value * Math.Pow(10, -6));
        public static implicit operator Metre(Nanometre self) => new Metre(self.Value * Math.Pow(10, -9));
        public static implicit operator Metre(Picometre self) => new Metre(self.Value * Math.Pow(10, -12));
        public static implicit operator Metre(Femtometre self) => new Metre(self.Value * Math.Pow(10, -15));
        public static implicit operator Metre(Attometre self) => new Metre(self.Value * Math.Pow(10, -18));
    }
}
