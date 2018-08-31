using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareAttometre {
        public static implicit operator SquareAttometre(SquareExametre self) => new SquareAttometre(self.Value * Math.Pow(10, 72));
        public static implicit operator SquareAttometre(SquarePetametre self) => new SquareAttometre(self.Value * Math.Pow(10, 66));
        public static implicit operator SquareAttometre(SquareTerametre self) => new SquareAttometre(self.Value * Math.Pow(10, 60));
        public static implicit operator SquareAttometre(SquareGigametre self) => new SquareAttometre(self.Value * Math.Pow(10, 54));
        public static implicit operator SquareAttometre(SquareMegametre self) => new SquareAttometre(self.Value * Math.Pow(10, 48));
        public static implicit operator SquareAttometre(SquareKilometre self) => new SquareAttometre(self.Value * Math.Pow(10, 42));
        public static implicit operator SquareAttometre(SquareHectometre self) => new SquareAttometre(self.Value * Math.Pow(10, 40));
        public static implicit operator SquareAttometre(SquareDecametre self) => new SquareAttometre(self.Value * Math.Pow(10, 38));
        public static implicit operator SquareAttometre(SquareMetre self) => new SquareAttometre(self.Value * Math.Pow(10, 36));
        public static implicit operator SquareAttometre(SquareDecimetre self) => new SquareAttometre(self.Value * Math.Pow(10, 34));
        public static implicit operator SquareAttometre(SquareCentimetre self) => new SquareAttometre(self.Value * Math.Pow(10, 32));
        public static implicit operator SquareAttometre(SquareMillimetre self) => new SquareAttometre(self.Value * Math.Pow(10, 30));
        public static implicit operator SquareAttometre(SquareMicrometre self) => new SquareAttometre(self.Value * Math.Pow(10, 24));
        public static implicit operator SquareAttometre(SquareNanometre self) => new SquareAttometre(self.Value * Math.Pow(10, 18));
        public static implicit operator SquareAttometre(SquarePicometre self) => new SquareAttometre(self.Value * Math.Pow(10, 12));
        public static implicit operator SquareAttometre(SquareFemtometre self) => new SquareAttometre(self.Value * Math.Pow(10, 6));
    }
}
