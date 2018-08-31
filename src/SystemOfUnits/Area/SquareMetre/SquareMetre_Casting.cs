using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareMetre {
        public static implicit operator SquareMetre(SquareExametre self) => new SquareMetre(self.Value * Math.Pow(10, 36));
        public static implicit operator SquareMetre(SquarePetametre self) => new SquareMetre(self.Value * Math.Pow(10, 30));
        public static implicit operator SquareMetre(SquareTerametre self) => new SquareMetre(self.Value * Math.Pow(10, 24));
        public static implicit operator SquareMetre(SquareGigametre self) => new SquareMetre(self.Value * Math.Pow(10, 18));
        public static implicit operator SquareMetre(SquareMegametre self) => new SquareMetre(self.Value * Math.Pow(10, 12));
        public static implicit operator SquareMetre(SquareKilometre self) => new SquareMetre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquareMetre(SquareHectometre self) => new SquareMetre(self.Value * Math.Pow(10, 4));
        public static implicit operator SquareMetre(SquareDecametre self) => new SquareMetre(self.Value * Math.Pow(10, 2));
        public static implicit operator SquareMetre(SquareDecimetre self) => new SquareMetre(self.Value * Math.Pow(10, -2));
        public static implicit operator SquareMetre(SquareCentimetre self) => new SquareMetre(self.Value * Math.Pow(10, -4));
        public static implicit operator SquareMetre(SquareMillimetre self) => new SquareMetre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquareMetre(SquareMicrometre self) => new SquareMetre(self.Value * Math.Pow(10, -12));
        public static implicit operator SquareMetre(SquareNanometre self) => new SquareMetre(self.Value * Math.Pow(10, -18));
        public static implicit operator SquareMetre(SquarePicometre self) => new SquareMetre(self.Value * Math.Pow(10, -24));
        public static implicit operator SquareMetre(SquareFemtometre self) => new SquareMetre(self.Value * Math.Pow(10, -30));
        public static implicit operator SquareMetre(SquareAttometre self) => new SquareMetre(self.Value * Math.Pow(10, -36));
    }
}
