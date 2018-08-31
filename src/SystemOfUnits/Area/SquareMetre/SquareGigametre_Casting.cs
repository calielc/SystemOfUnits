using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareGigametre {
        public static implicit operator SquareGigametre(SquareExametre self) => new SquareGigametre(self.Value * Math.Pow(10, 18));
        public static implicit operator SquareGigametre(SquarePetametre self) => new SquareGigametre(self.Value * Math.Pow(10, 12));
        public static implicit operator SquareGigametre(SquareTerametre self) => new SquareGigametre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquareGigametre(SquareMegametre self) => new SquareGigametre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquareGigametre(SquareKilometre self) => new SquareGigametre(self.Value * Math.Pow(10, -12));
        public static implicit operator SquareGigametre(SquareHectometre self) => new SquareGigametre(self.Value * Math.Pow(10, -14));
        public static implicit operator SquareGigametre(SquareDecametre self) => new SquareGigametre(self.Value * Math.Pow(10, -16));
        public static implicit operator SquareGigametre(SquareMetre self) => new SquareGigametre(self.Value * Math.Pow(10, -18));
        public static implicit operator SquareGigametre(SquareDecimetre self) => new SquareGigametre(self.Value * Math.Pow(10, -20));
        public static implicit operator SquareGigametre(SquareCentimetre self) => new SquareGigametre(self.Value * Math.Pow(10, -22));
        public static implicit operator SquareGigametre(SquareMillimetre self) => new SquareGigametre(self.Value * Math.Pow(10, -24));
        public static implicit operator SquareGigametre(SquareMicrometre self) => new SquareGigametre(self.Value * Math.Pow(10, -30));
        public static implicit operator SquareGigametre(SquareNanometre self) => new SquareGigametre(self.Value * Math.Pow(10, -36));
        public static implicit operator SquareGigametre(SquarePicometre self) => new SquareGigametre(self.Value * Math.Pow(10, -42));
        public static implicit operator SquareGigametre(SquareFemtometre self) => new SquareGigametre(self.Value * Math.Pow(10, -48));
        public static implicit operator SquareGigametre(SquareAttometre self) => new SquareGigametre(self.Value * Math.Pow(10, -54));
    }
}
