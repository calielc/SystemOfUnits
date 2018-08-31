namespace SystemOfUnits.Length.Metre {
    using CubicMetre = Volume.CubicMetre.CubicMetre;
    using SquareMetre = Area.SquareMetre.SquareMetre;

    public partial struct Metre {
        public static SquareMetre operator *(Metre left, Metre right) => new SquareMetre(left.Value * right.Value);

        public static CubicMetre operator *(SquareMetre left, Metre right) => new CubicMetre(left.Value * right.Value);
        public static CubicMetre operator *(Metre left, SquareMetre right) => new CubicMetre(left.Value * right.Value);
    }
}