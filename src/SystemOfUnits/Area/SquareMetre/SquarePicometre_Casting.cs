using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquarePicometre {
        public static implicit operator SquarePicometre(SquareExametre self) => new SquarePicometre(self.Value * Math.Pow(10, 60));
        public static implicit operator SquarePicometre(SquarePetametre self) => new SquarePicometre(self.Value * Math.Pow(10, 54));
        public static implicit operator SquarePicometre(SquareTerametre self) => new SquarePicometre(self.Value * Math.Pow(10, 48));
        public static implicit operator SquarePicometre(SquareGigametre self) => new SquarePicometre(self.Value * Math.Pow(10, 42));
        public static implicit operator SquarePicometre(SquareMegametre self) => new SquarePicometre(self.Value * Math.Pow(10, 36));
        public static implicit operator SquarePicometre(SquareKilometre self) => new SquarePicometre(self.Value * Math.Pow(10, 30));
        public static implicit operator SquarePicometre(SquareHectometre self) => new SquarePicometre(self.Value * Math.Pow(10, 28));
        public static implicit operator SquarePicometre(SquareDecametre self) => new SquarePicometre(self.Value * Math.Pow(10, 26));
        public static implicit operator SquarePicometre(SquareMetre self) => new SquarePicometre(self.Value * Math.Pow(10, 24));
        public static implicit operator SquarePicometre(SquareDecimetre self) => new SquarePicometre(self.Value * Math.Pow(10, 22));
        public static implicit operator SquarePicometre(SquareCentimetre self) => new SquarePicometre(self.Value * Math.Pow(10, 20));
        public static implicit operator SquarePicometre(SquareMillimetre self) => new SquarePicometre(self.Value * Math.Pow(10, 18));
        public static implicit operator SquarePicometre(SquareMicrometre self) => new SquarePicometre(self.Value * Math.Pow(10, 12));
        public static implicit operator SquarePicometre(SquareNanometre self) => new SquarePicometre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquarePicometre(SquareFemtometre self) => new SquarePicometre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquarePicometre(SquareAttometre self) => new SquarePicometre(self.Value * Math.Pow(10, -12));
    }
}
