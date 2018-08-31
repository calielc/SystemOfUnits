using System;

namespace SystemOfUnits.Area.SquareMetre {
    public partial struct SquarePetametre {
        public static implicit operator SquarePetametre(SquareExametre self) => new SquarePetametre(self.Value * Math.Pow(10, 6));
        public static implicit operator SquarePetametre(SquareTerametre self) => new SquarePetametre(self.Value * Math.Pow(10, -6));
        public static implicit operator SquarePetametre(SquareGigametre self) => new SquarePetametre(self.Value * Math.Pow(10, -12));
        public static implicit operator SquarePetametre(SquareMegametre self) => new SquarePetametre(self.Value * Math.Pow(10, -18));
        public static implicit operator SquarePetametre(SquareKilometre self) => new SquarePetametre(self.Value * Math.Pow(10, -24));
        public static implicit operator SquarePetametre(SquareHectometre self) => new SquarePetametre(self.Value * Math.Pow(10, -26));
        public static implicit operator SquarePetametre(SquareDecametre self) => new SquarePetametre(self.Value * Math.Pow(10, -28));
        public static implicit operator SquarePetametre(SquareMetre self) => new SquarePetametre(self.Value * Math.Pow(10, -30));
        public static implicit operator SquarePetametre(SquareDecimetre self) => new SquarePetametre(self.Value * Math.Pow(10, -32));
        public static implicit operator SquarePetametre(SquareCentimetre self) => new SquarePetametre(self.Value * Math.Pow(10, -34));
        public static implicit operator SquarePetametre(SquareMillimetre self) => new SquarePetametre(self.Value * Math.Pow(10, -36));
        public static implicit operator SquarePetametre(SquareMicrometre self) => new SquarePetametre(self.Value * Math.Pow(10, -42));
        public static implicit operator SquarePetametre(SquareNanometre self) => new SquarePetametre(self.Value * Math.Pow(10, -48));
        public static implicit operator SquarePetametre(SquarePicometre self) => new SquarePetametre(self.Value * Math.Pow(10, -54));
        public static implicit operator SquarePetametre(SquareFemtometre self) => new SquarePetametre(self.Value * Math.Pow(10, -60));
        public static implicit operator SquarePetametre(SquareAttometre self) => new SquarePetametre(self.Value * Math.Pow(10, -66));
    }
}
