using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareExametre {
        public static implicit operator SquareExametre(SquarePetametre self) => new SquareExametre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquareExametre(SquareTerametre self) => new SquareExametre(self.Value * Math.Pow(10, -12));
        public static implicit operator SquareExametre(SquareGigametre self) => new SquareExametre(self.Value * Math.Pow(10, -18));
        public static implicit operator SquareExametre(SquareMegametre self) => new SquareExametre(self.Value * Math.Pow(10, -24));
        public static implicit operator SquareExametre(SquareKilometre self) => new SquareExametre(self.Value * Math.Pow(10, -30));
        public static implicit operator SquareExametre(SquareHectometre self) => new SquareExametre(self.Value * Math.Pow(10, -32));
        public static implicit operator SquareExametre(SquareDecametre self) => new SquareExametre(self.Value * Math.Pow(10, -34));
        public static implicit operator SquareExametre(SquareMetre self) => new SquareExametre(self.Value * Math.Pow(10, -36));
        public static implicit operator SquareExametre(SquareDecimetre self) => new SquareExametre(self.Value * Math.Pow(10, -38));
        public static implicit operator SquareExametre(SquareCentimetre self) => new SquareExametre(self.Value * Math.Pow(10, -40));
        public static implicit operator SquareExametre(SquareMillimetre self) => new SquareExametre(self.Value * Math.Pow(10, -42));
        public static implicit operator SquareExametre(SquareMicrometre self) => new SquareExametre(self.Value * Math.Pow(10, -48));
        public static implicit operator SquareExametre(SquareNanometre self) => new SquareExametre(self.Value * Math.Pow(10, -54));
        public static implicit operator SquareExametre(SquarePicometre self) => new SquareExametre(self.Value * Math.Pow(10, -60));
        public static implicit operator SquareExametre(SquareFemtometre self) => new SquareExametre(self.Value * Math.Pow(10, -66));
        public static implicit operator SquareExametre(SquareAttometre self) => new SquareExametre(self.Value * Math.Pow(10, -72));
    }
}
