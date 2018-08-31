using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareKilometre {
        public static implicit operator SquareKilometre(SquareExametre self) => new SquareKilometre(self.Value * Math.Pow(10, 30));
        public static implicit operator SquareKilometre(SquarePetametre self) => new SquareKilometre(self.Value * Math.Pow(10, 24));
        public static implicit operator SquareKilometre(SquareTerametre self) => new SquareKilometre(self.Value * Math.Pow(10, 18));
        public static implicit operator SquareKilometre(SquareGigametre self) => new SquareKilometre(self.Value * Math.Pow(10, 12));
        public static implicit operator SquareKilometre(SquareMegametre self) => new SquareKilometre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquareKilometre(SquareHectometre self) => new SquareKilometre(self.Value * Math.Pow(10, -2));
        public static implicit operator SquareKilometre(SquareDecametre self) => new SquareKilometre(self.Value * Math.Pow(10, -4));
        public static implicit operator SquareKilometre(SquareMetre self) => new SquareKilometre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquareKilometre(SquareDecimetre self) => new SquareKilometre(self.Value * Math.Pow(10, -8));
        public static implicit operator SquareKilometre(SquareCentimetre self) => new SquareKilometre(self.Value * Math.Pow(10, -10));
        public static implicit operator SquareKilometre(SquareMillimetre self) => new SquareKilometre(self.Value * Math.Pow(10, -12));
        public static implicit operator SquareKilometre(SquareMicrometre self) => new SquareKilometre(self.Value * Math.Pow(10, -18));
        public static implicit operator SquareKilometre(SquareNanometre self) => new SquareKilometre(self.Value * Math.Pow(10, -24));
        public static implicit operator SquareKilometre(SquarePicometre self) => new SquareKilometre(self.Value * Math.Pow(10, -30));
        public static implicit operator SquareKilometre(SquareFemtometre self) => new SquareKilometre(self.Value * Math.Pow(10, -36));
        public static implicit operator SquareKilometre(SquareAttometre self) => new SquareKilometre(self.Value * Math.Pow(10, -42));
    }
}
