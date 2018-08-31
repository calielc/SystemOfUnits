namespace SystemOfUnits.Temperature {
    public partial struct Kelvin : ITemperatureUnit {
        Kelvin ITemperatureUnit.ToKelvin() => this;
    }
}