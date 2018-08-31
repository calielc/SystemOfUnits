namespace SystemOfUnits.Temperature {
    public partial struct Fahrenheit : ITemperatureUnit {
        Kelvin ITemperatureUnit.ToKelvin() => this;
    }
}