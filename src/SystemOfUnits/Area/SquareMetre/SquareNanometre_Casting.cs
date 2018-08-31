using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareNanometre {
        public static implicit operator SquareNanometre(SquareExametre self) => new SquareNanometre(self.Value * Math.Pow(10, 54));
        public static implicit operator SquareNanometre(SquarePetametre self) => new SquareNanometre(self.Value * Math.Pow(10, 48));
        public static implicit operator SquareNanometre(SquareTerametre self) => new SquareNanometre(self.Value * Math.Pow(10, 42));
        public static implicit operator SquareNanometre(SquareGigametre self) => new SquareNanometre(self.Value * Math.Pow(10, 36));
        public static implicit operator SquareNanometre(SquareMegametre self) => new SquareNanometre(self.Value * Math.Pow(10, 30));
        public static implicit operator SquareNanometre(SquareKilometre self) => new SquareNanometre(self.Value * Math.Pow(10, 24));
        public static implicit operator SquareNanometre(SquareHectometre self) => new SquareNanometre(self.Value * Math.Pow(10, 22));
        public static implicit operator SquareNanometre(SquareDecametre self) => new SquareNanometre(self.Value * Math.Pow(10, 20));
        public static implicit operator SquareNanometre(SquareMetre self) => new SquareNanometre(self.Value * Math.Pow(10, 18));
        public static implicit operator SquareNanometre(SquareDecimetre self) => new SquareNanometre(self.Value * Math.Pow(10, 16));
        public static implicit operator SquareNanometre(SquareCentimetre self) => new SquareNanometre(self.Value * Math.Pow(10, 14));
        public static implicit operator SquareNanometre(SquareMillimetre self) => new SquareNanometre(self.Value * Math.Pow(10, 12));
        public static implicit operator SquareNanometre(SquareMicrometre self) => new SquareNanometre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquareNanometre(SquarePicometre self) => new SquareNanometre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquareNanometre(SquareFemtometre self) => new SquareNanometre(self.Value * Math.Pow(10, -12));
        public static implicit operator SquareNanometre(SquareAttometre self) => new SquareNanometre(self.Value * Math.Pow(10, -18));
    }
}
