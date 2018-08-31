using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareTerametre {
        public static implicit operator SquareTerametre(SquareExametre self) => new SquareTerametre(self.Value * Math.Pow(10, 12));
        public static implicit operator SquareTerametre(SquarePetametre self) => new SquareTerametre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquareTerametre(SquareGigametre self) => new SquareTerametre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquareTerametre(SquareMegametre self) => new SquareTerametre(self.Value * Math.Pow(10, -12));
        public static implicit operator SquareTerametre(SquareKilometre self) => new SquareTerametre(self.Value * Math.Pow(10, -18));
        public static implicit operator SquareTerametre(SquareHectometre self) => new SquareTerametre(self.Value * Math.Pow(10, -20));
        public static implicit operator SquareTerametre(SquareDecametre self) => new SquareTerametre(self.Value * Math.Pow(10, -22));
        public static implicit operator SquareTerametre(SquareMetre self) => new SquareTerametre(self.Value * Math.Pow(10, -24));
        public static implicit operator SquareTerametre(SquareDecimetre self) => new SquareTerametre(self.Value * Math.Pow(10, -26));
        public static implicit operator SquareTerametre(SquareCentimetre self) => new SquareTerametre(self.Value * Math.Pow(10, -28));
        public static implicit operator SquareTerametre(SquareMillimetre self) => new SquareTerametre(self.Value * Math.Pow(10, -30));
        public static implicit operator SquareTerametre(SquareMicrometre self) => new SquareTerametre(self.Value * Math.Pow(10, -36));
        public static implicit operator SquareTerametre(SquareNanometre self) => new SquareTerametre(self.Value * Math.Pow(10, -42));
        public static implicit operator SquareTerametre(SquarePicometre self) => new SquareTerametre(self.Value * Math.Pow(10, -48));
        public static implicit operator SquareTerametre(SquareFemtometre self) => new SquareTerametre(self.Value * Math.Pow(10, -54));
        public static implicit operator SquareTerametre(SquareAttometre self) => new SquareTerametre(self.Value * Math.Pow(10, -60));
    }
}
