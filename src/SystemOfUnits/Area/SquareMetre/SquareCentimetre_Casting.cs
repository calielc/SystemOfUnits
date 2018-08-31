using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareCentimetre {
        public static implicit operator SquareCentimetre(SquareExametre self) => new SquareCentimetre(self.Value * Math.Pow(10, 40));
        public static implicit operator SquareCentimetre(SquarePetametre self) => new SquareCentimetre(self.Value * Math.Pow(10, 34));
        public static implicit operator SquareCentimetre(SquareTerametre self) => new SquareCentimetre(self.Value * Math.Pow(10, 28));
        public static implicit operator SquareCentimetre(SquareGigametre self) => new SquareCentimetre(self.Value * Math.Pow(10, 22));
        public static implicit operator SquareCentimetre(SquareMegametre self) => new SquareCentimetre(self.Value * Math.Pow(10, 16));
        public static implicit operator SquareCentimetre(SquareKilometre self) => new SquareCentimetre(self.Value * Math.Pow(10, 10));
        public static implicit operator SquareCentimetre(SquareHectometre self) => new SquareCentimetre(self.Value * Math.Pow(10, 8));
        public static implicit operator SquareCentimetre(SquareDecametre self) => new SquareCentimetre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquareCentimetre(SquareMetre self) => new SquareCentimetre(self.Value * Math.Pow(10, 4));
        public static implicit operator SquareCentimetre(SquareDecimetre self) => new SquareCentimetre(self.Value * Math.Pow(10, 2));
        public static implicit operator SquareCentimetre(SquareMillimetre self) => new SquareCentimetre(self.Value * Math.Pow(10, -2));
        public static implicit operator SquareCentimetre(SquareMicrometre self) => new SquareCentimetre(self.Value * Math.Pow(10, -8));
        public static implicit operator SquareCentimetre(SquareNanometre self) => new SquareCentimetre(self.Value * Math.Pow(10, -14));
        public static implicit operator SquareCentimetre(SquarePicometre self) => new SquareCentimetre(self.Value * Math.Pow(10, -20));
        public static implicit operator SquareCentimetre(SquareFemtometre self) => new SquareCentimetre(self.Value * Math.Pow(10, -26));
        public static implicit operator SquareCentimetre(SquareAttometre self) => new SquareCentimetre(self.Value * Math.Pow(10, -32));
    }
}
