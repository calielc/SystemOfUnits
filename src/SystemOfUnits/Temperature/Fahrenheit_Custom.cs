namespace SystemOfUnits.Temperature {
    public partial struct Fahrenheit {
        public static readonly Fahrenheit AbsoluteZero = new Fahrenheit(-459.67d);

        public static implicit operator Fahrenheit(Kelvin self) => new Fahrenheit(self.Value * (9d / 5d) - 459.67d);
        public static implicit operator Kelvin(Fahrenheit self) => new Kelvin((self.Value + 459.67d) * (5d / 9d));

        public static implicit operator Fahrenheit(Celsius self) => new Fahrenheit(self.Value * (9d / 5d) + 32d);
        public static implicit operator Celsius(Fahrenheit self) => new Celsius((self.Value - 32d) * (5d / 9d));
    }
}