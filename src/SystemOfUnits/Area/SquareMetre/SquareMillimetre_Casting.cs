using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareMillimetre {
        public static implicit operator SquareMillimetre(SquareExametre self) => new SquareMillimetre(self.Value * Math.Pow(10, 42));
        public static implicit operator SquareMillimetre(SquarePetametre self) => new SquareMillimetre(self.Value * Math.Pow(10, 36));
        public static implicit operator SquareMillimetre(SquareTerametre self) => new SquareMillimetre(self.Value * Math.Pow(10, 30));
        public static implicit operator SquareMillimetre(SquareGigametre self) => new SquareMillimetre(self.Value * Math.Pow(10, 24));
        public static implicit operator SquareMillimetre(SquareMegametre self) => new SquareMillimetre(self.Value * Math.Pow(10, 18));
        public static implicit operator SquareMillimetre(SquareKilometre self) => new SquareMillimetre(self.Value * Math.Pow(10, 12));
        public static implicit operator SquareMillimetre(SquareHectometre self) => new SquareMillimetre(self.Value * Math.Pow(10, 10));
        public static implicit operator SquareMillimetre(SquareDecametre self) => new SquareMillimetre(self.Value * Math.Pow(10, 8));
        public static implicit operator SquareMillimetre(SquareMetre self) => new SquareMillimetre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquareMillimetre(SquareDecimetre self) => new SquareMillimetre(self.Value * Math.Pow(10, 4));
        public static implicit operator SquareMillimetre(SquareCentimetre self) => new SquareMillimetre(self.Value * Math.Pow(10, 2));
        public static implicit operator SquareMillimetre(SquareMicrometre self) => new SquareMillimetre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquareMillimetre(SquareNanometre self) => new SquareMillimetre(self.Value * Math.Pow(10, -12));
        public static implicit operator SquareMillimetre(SquarePicometre self) => new SquareMillimetre(self.Value * Math.Pow(10, -18));
        public static implicit operator SquareMillimetre(SquareFemtometre self) => new SquareMillimetre(self.Value * Math.Pow(10, -24));
        public static implicit operator SquareMillimetre(SquareAttometre self) => new SquareMillimetre(self.Value * Math.Pow(10, -30));
    }
}
