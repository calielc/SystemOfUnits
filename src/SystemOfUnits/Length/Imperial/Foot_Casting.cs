namespace SystemOfUnits.Length.Imperial {
    public partial struct Foot {
        public static implicit operator Foot(Inch self) => new Foot(self.Value * Inch.FootRatio);
        public static implicit operator Foot(Yard self) => new Foot(self.Value * Yard.FootRatio);
        public static implicit operator Foot(Mile self) => new Foot(self.Value * Mile.FootRatio);
    }
}
