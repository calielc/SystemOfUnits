namespace SystemOfUnits.Angle {
    public partial struct Milliradian {
        internal const double RadianRatio = 0.001d;

        public static implicit operator Milliradian(Radian self) => new Milliradian(self.Value / RadianRatio);
        public static implicit operator Milliradian(Degree self) => new Milliradian(self.Value * Degree.RadianRatio / RadianRatio);
    }
}
