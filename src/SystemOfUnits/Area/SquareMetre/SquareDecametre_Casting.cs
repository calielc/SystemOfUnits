using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareDecametre {
        public static implicit operator SquareDecametre(SquareExametre self) => new SquareDecametre(self.Value * Math.Pow(10, 34));
        public static implicit operator SquareDecametre(SquarePetametre self) => new SquareDecametre(self.Value * Math.Pow(10, 28));
        public static implicit operator SquareDecametre(SquareTerametre self) => new SquareDecametre(self.Value * Math.Pow(10, 22));
        public static implicit operator SquareDecametre(SquareGigametre self) => new SquareDecametre(self.Value * Math.Pow(10, 16));
        public static implicit operator SquareDecametre(SquareMegametre self) => new SquareDecametre(self.Value * Math.Pow(10, 10));
        public static implicit operator SquareDecametre(SquareKilometre self) => new SquareDecametre(self.Value * Math.Pow(10, 4));
        public static implicit operator SquareDecametre(SquareHectometre self) => new SquareDecametre(self.Value * Math.Pow(10, 2));
        public static implicit operator SquareDecametre(SquareMetre self) => new SquareDecametre(self.Value * Math.Pow(10, -2));
        public static implicit operator SquareDecametre(SquareDecimetre self) => new SquareDecametre(self.Value * Math.Pow(10, -4));
        public static implicit operator SquareDecametre(SquareCentimetre self) => new SquareDecametre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquareDecametre(SquareMillimetre self) => new SquareDecametre(self.Value * Math.Pow(10, -8));
        public static implicit operator SquareDecametre(SquareMicrometre self) => new SquareDecametre(self.Value * Math.Pow(10, -14));
        public static implicit operator SquareDecametre(SquareNanometre self) => new SquareDecametre(self.Value * Math.Pow(10, -20));
        public static implicit operator SquareDecametre(SquarePicometre self) => new SquareDecametre(self.Value * Math.Pow(10, -26));
        public static implicit operator SquareDecametre(SquareFemtometre self) => new SquareDecametre(self.Value * Math.Pow(10, -32));
        public static implicit operator SquareDecametre(SquareAttometre self) => new SquareDecametre(self.Value * Math.Pow(10, -38));
    }
}
