namespace SystemOfUnits.Angle {
    public partial struct Radian {
        public static implicit operator Radian(Milliradian self) => new Radian(self.Value * Milliradian.RadianRatio);
        public static implicit operator Radian(Degree self) => new Radian(self.Value * Degree.RadianRatio);
    }
}
