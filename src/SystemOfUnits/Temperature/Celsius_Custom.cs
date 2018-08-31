namespace SystemOfUnits.Temperature {
    public partial struct Celsius {
        private const double KelvinShift = -273.15d;
        public static readonly Celsius AbsoluteZero = new Celsius(KelvinShift);

        public static implicit operator Celsius(Kelvin self) => new Celsius(self.Value + KelvinShift);
        public static implicit operator Kelvin(Celsius self) => new Kelvin(self.Value - KelvinShift);
    }
}