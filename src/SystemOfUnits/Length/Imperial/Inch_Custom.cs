using SystemOfUnits.Length.Metre;

namespace SystemOfUnits.Length.Imperial {
    public partial struct Inch {
        internal const double CentimetresInAnInch = 2.54;
        public static implicit operator Centimetre(Inch self) => new Centimetre(self.Value * CentimetresInAnInch);
        public static implicit operator Inch(Centimetre self) => new Inch(self.Value / CentimetresInAnInch);
    }
}