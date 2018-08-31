using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareDecimetre {
        public static implicit operator SquareDecimetre(SquareExametre self) => new SquareDecimetre(self.Value * Math.Pow(10, 38));
        public static implicit operator SquareDecimetre(SquarePetametre self) => new SquareDecimetre(self.Value * Math.Pow(10, 32));
        public static implicit operator SquareDecimetre(SquareTerametre self) => new SquareDecimetre(self.Value * Math.Pow(10, 26));
        public static implicit operator SquareDecimetre(SquareGigametre self) => new SquareDecimetre(self.Value * Math.Pow(10, 20));
        public static implicit operator SquareDecimetre(SquareMegametre self) => new SquareDecimetre(self.Value * Math.Pow(10, 14));
        public static implicit operator SquareDecimetre(SquareKilometre self) => new SquareDecimetre(self.Value * Math.Pow(10, 8));
        public static implicit operator SquareDecimetre(SquareHectometre self) => new SquareDecimetre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquareDecimetre(SquareDecametre self) => new SquareDecimetre(self.Value * Math.Pow(10, 4));
        public static implicit operator SquareDecimetre(SquareMetre self) => new SquareDecimetre(self.Value * Math.Pow(10, 2));
        public static implicit operator SquareDecimetre(SquareCentimetre self) => new SquareDecimetre(self.Value * Math.Pow(10, -2));
        public static implicit operator SquareDecimetre(SquareMillimetre self) => new SquareDecimetre(self.Value * Math.Pow(10, -4));
        public static implicit operator SquareDecimetre(SquareMicrometre self) => new SquareDecimetre(self.Value * Math.Pow(10, -10));
        public static implicit operator SquareDecimetre(SquareNanometre self) => new SquareDecimetre(self.Value * Math.Pow(10, -16));
        public static implicit operator SquareDecimetre(SquarePicometre self) => new SquareDecimetre(self.Value * Math.Pow(10, -22));
        public static implicit operator SquareDecimetre(SquareFemtometre self) => new SquareDecimetre(self.Value * Math.Pow(10, -28));
        public static implicit operator SquareDecimetre(SquareAttometre self) => new SquareDecimetre(self.Value * Math.Pow(10, -34));
    }
}
