namespace SystemOfUnits.Angle {
    public partial struct Degree {
        internal const double RadianRatio = System.Math.PI / 180d;

        public static implicit operator Degree(Radian self) => new Degree(self.Value / RadianRatio);
        public static implicit operator Degree(Milliradian self) => new Degree(self.Value * Milliradian.RadianRatio / RadianRatio);
    }
}
