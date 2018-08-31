using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareMegametre {
        public static implicit operator SquareMegametre(SquareExametre self) => new SquareMegametre(self.Value * Math.Pow(10, 24));
        public static implicit operator SquareMegametre(SquarePetametre self) => new SquareMegametre(self.Value * Math.Pow(10, 18));
        public static implicit operator SquareMegametre(SquareTerametre self) => new SquareMegametre(self.Value * Math.Pow(10, 12));
        public static implicit operator SquareMegametre(SquareGigametre self) => new SquareMegametre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquareMegametre(SquareKilometre self) => new SquareMegametre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquareMegametre(SquareHectometre self) => new SquareMegametre(self.Value * Math.Pow(10, -8));
        public static implicit operator SquareMegametre(SquareDecametre self) => new SquareMegametre(self.Value * Math.Pow(10, -10));
        public static implicit operator SquareMegametre(SquareMetre self) => new SquareMegametre(self.Value * Math.Pow(10, -12));
        public static implicit operator SquareMegametre(SquareDecimetre self) => new SquareMegametre(self.Value * Math.Pow(10, -14));
        public static implicit operator SquareMegametre(SquareCentimetre self) => new SquareMegametre(self.Value * Math.Pow(10, -16));
        public static implicit operator SquareMegametre(SquareMillimetre self) => new SquareMegametre(self.Value * Math.Pow(10, -18));
        public static implicit operator SquareMegametre(SquareMicrometre self) => new SquareMegametre(self.Value * Math.Pow(10, -24));
        public static implicit operator SquareMegametre(SquareNanometre self) => new SquareMegametre(self.Value * Math.Pow(10, -30));
        public static implicit operator SquareMegametre(SquarePicometre self) => new SquareMegametre(self.Value * Math.Pow(10, -36));
        public static implicit operator SquareMegametre(SquareFemtometre self) => new SquareMegametre(self.Value * Math.Pow(10, -42));
        public static implicit operator SquareMegametre(SquareAttometre self) => new SquareMegametre(self.Value * Math.Pow(10, -48));
    }
}
