namespace SystemOfUnits.Length.Imperial {
    public partial struct Yard {
        internal const double FootRatio = 3;

        public static implicit operator Yard(Inch self) => new Yard(self.Value * Inch.FootRatio / FootRatio);
        public static implicit operator Yard(Foot self) => new Yard(self.Value / FootRatio);
        public static implicit operator Yard(Mile self) => new Yard(self.Value * Mile.FootRatio / FootRatio);
    }
}
