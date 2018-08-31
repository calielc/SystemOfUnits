using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquareFemtometre {
        public static implicit operator SquareFemtometre(SquareExametre self) => new SquareFemtometre(self.Value * Math.Pow(10, 66));
        public static implicit operator SquareFemtometre(SquarePetametre self) => new SquareFemtometre(self.Value * Math.Pow(10, 60));
        public static implicit operator SquareFemtometre(SquareTerametre self) => new SquareFemtometre(self.Value * Math.Pow(10, 54));
        public static implicit operator SquareFemtometre(SquareGigametre self) => new SquareFemtometre(self.Value * Math.Pow(10, 48));
        public static implicit operator SquareFemtometre(SquareMegametre self) => new SquareFemtometre(self.Value * Math.Pow(10, 42));
        public static implicit operator SquareFemtometre(SquareKilometre self) => new SquareFemtometre(self.Value * Math.Pow(10, 36));
        public static implicit operator SquareFemtometre(SquareHectometre self) => new SquareFemtometre(self.Value * Math.Pow(10, 34));
        public static implicit operator SquareFemtometre(SquareDecametre self) => new SquareFemtometre(self.Value * Math.Pow(10, 32));
        public static implicit operator SquareFemtometre(SquareMetre self) => new SquareFemtometre(self.Value * Math.Pow(10, 30));
        public static implicit operator SquareFemtometre(SquareDecimetre self) => new SquareFemtometre(self.Value * Math.Pow(10, 28));
        public static implicit operator SquareFemtometre(SquareCentimetre self) => new SquareFemtometre(self.Value * Math.Pow(10, 26));
        public static implicit operator SquareFemtometre(SquareMillimetre self) => new SquareFemtometre(self.Value * Math.Pow(10, 24));
        public static implicit operator SquareFemtometre(SquareMicrometre self) => new SquareFemtometre(self.Value * Math.Pow(10, 18));
        public static implicit operator SquareFemtometre(SquareNanometre self) => new SquareFemtometre(self.Value * Math.Pow(10, 12));
        public static implicit operator SquareFemtometre(SquarePicometre self) => new SquareFemtometre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquareFemtometre(SquareAttometre self) => new SquareFemtometre(self.Value * Math.Pow(10, -6));
    }
}
