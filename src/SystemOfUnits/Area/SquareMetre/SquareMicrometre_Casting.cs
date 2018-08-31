using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareMicrometre {
        public static implicit operator SquareMicrometre(SquareExametre self) => new SquareMicrometre(self.Value * Math.Pow(10, 48));
        public static implicit operator SquareMicrometre(SquarePetametre self) => new SquareMicrometre(self.Value * Math.Pow(10, 42));
        public static implicit operator SquareMicrometre(SquareTerametre self) => new SquareMicrometre(self.Value * Math.Pow(10, 36));
        public static implicit operator SquareMicrometre(SquareGigametre self) => new SquareMicrometre(self.Value * Math.Pow(10, 30));
        public static implicit operator SquareMicrometre(SquareMegametre self) => new SquareMicrometre(self.Value * Math.Pow(10, 24));
        public static implicit operator SquareMicrometre(SquareKilometre self) => new SquareMicrometre(self.Value * Math.Pow(10, 18));
        public static implicit operator SquareMicrometre(SquareHectometre self) => new SquareMicrometre(self.Value * Math.Pow(10, 16));
        public static implicit operator SquareMicrometre(SquareDecametre self) => new SquareMicrometre(self.Value * Math.Pow(10, 14));
        public static implicit operator SquareMicrometre(SquareMetre self) => new SquareMicrometre(self.Value * Math.Pow(10, 12));
        public static implicit operator SquareMicrometre(SquareDecimetre self) => new SquareMicrometre(self.Value * Math.Pow(10, 10));
        public static implicit operator SquareMicrometre(SquareCentimetre self) => new SquareMicrometre(self.Value * Math.Pow(10, 8));
        public static implicit operator SquareMicrometre(SquareMillimetre self) => new SquareMicrometre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquareMicrometre(SquareNanometre self) => new SquareMicrometre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquareMicrometre(SquarePicometre self) => new SquareMicrometre(self.Value * Math.Pow(10, -12));
        public static implicit operator SquareMicrometre(SquareFemtometre self) => new SquareMicrometre(self.Value * Math.Pow(10, -18));
        public static implicit operator SquareMicrometre(SquareAttometre self) => new SquareMicrometre(self.Value * Math.Pow(10, -24));
    }
}
