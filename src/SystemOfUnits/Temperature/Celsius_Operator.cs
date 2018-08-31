namespace SystemOfUnits.Temperature {
    public partial struct Celsius : ITemperatureUnit {
        Kelvin ITemperatureUnit.ToKelvin() => this;
    }
}