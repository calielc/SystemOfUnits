namespace SystemOfUnits.Length.Imperial {
    public partial struct Inch {
        internal const double FootRatio = 1d / 12d;

        public static implicit operator Inch(Foot self) => new Inch(self.Value / FootRatio);
        public static implicit operator Inch(Yard self) => new Inch(self.Value * Yard.FootRatio / FootRatio);
        public static implicit operator Inch(Mile self) => new Inch(self.Value * Mile.FootRatio / FootRatio);
    }
}
