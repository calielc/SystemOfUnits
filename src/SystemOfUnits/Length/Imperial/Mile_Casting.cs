namespace SystemOfUnits.Length.Imperial {
    public partial struct Mile {
        internal const double FootRatio = 5_280;

        public static implicit operator Mile(Inch self) => new Mile(self.Value * Inch.FootRatio / FootRatio);
        public static implicit operator Mile(Foot self) => new Mile(self.Value / FootRatio);
        public static implicit operator Mile(Yard self) => new Mile(self.Value * Yard.FootRatio / FootRatio);
    }
}
