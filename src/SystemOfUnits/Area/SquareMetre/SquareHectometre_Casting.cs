using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareHectometre {
        public static implicit operator SquareHectometre(SquareExametre self) => new SquareHectometre(self.Value * Math.Pow(10, 32));
        public static implicit operator SquareHectometre(SquarePetametre self) => new SquareHectometre(self.Value * Math.Pow(10, 26));
        public static implicit operator SquareHectometre(SquareTerametre self) => new SquareHectometre(self.Value * Math.Pow(10, 20));
        public static implicit operator SquareHectometre(SquareGigametre self) => new SquareHectometre(self.Value * Math.Pow(10, 14));
        public static implicit operator SquareHectometre(SquareMegametre self) => new SquareHectometre(self.Value * Math.Pow(10, 8));
        public static implicit operator SquareHectometre(SquareKilometre self) => new SquareHectometre(self.Value * Math.Pow(10, 2));
        public static implicit operator SquareHectometre(SquareDecametre self) => new SquareHectometre(self.Value * Math.Pow(10, -2));
        public static implicit operator SquareHectometre(SquareMetre self) => new SquareHectometre(self.Value * Math.Pow(10, -4));
        public static implicit operator SquareHectometre(SquareDecimetre self) => new SquareHectometre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquareHectometre(SquareCentimetre self) => new SquareHectometre(self.Value * Math.Pow(10, -8));
        public static implicit operator SquareHectometre(SquareMillimetre self) => new SquareHectometre(self.Value * Math.Pow(10, -10));
        public static implicit operator SquareHectometre(SquareMicrometre self) => new SquareHectometre(self.Value * Math.Pow(10, -16));
        public static implicit operator SquareHectometre(SquareNanometre self) => new SquareHectometre(self.Value * Math.Pow(10, -22));
        public static implicit operator SquareHectometre(SquarePicometre self) => new SquareHectometre(self.Value * Math.Pow(10, -28));
        public static implicit operator SquareHectometre(SquareFemtometre self) => new SquareHectometre(self.Value * Math.Pow(10, -34));
        public static implicit operator SquareHectometre(SquareAttometre self) => new SquareHectometre(self.Value * Math.Pow(10, -40));
    }
}
