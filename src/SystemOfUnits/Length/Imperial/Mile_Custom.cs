using SystemOfUnits.Length.Metre;

namespace SystemOfUnits.Length.Imperial {
    public partial struct Mile {
        internal const double KilometresInAMile = 1.609344d;
        public static implicit operator Kilometre(Mile self) => new Kilometre(self.Value * KilometresInAMile);
        public static implicit operator Mile(Kilometre self) => new Mile(self.Value / KilometresInAMile);
    }
}