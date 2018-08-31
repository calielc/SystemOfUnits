namespace SystemOfUnits.Time {
    public partial struct Millisecond {
        internal const double DayPortion = 1d / (24d * 60d * 60d * 1_000d);

        public static implicit operator Millisecond(Year self) => new Millisecond(self.Value * Year.DayPortion / DayPortion);
        public static implicit operator Millisecond(Month self) => new Millisecond(self.Value * Month.DayPortion / DayPortion);
        public static implicit operator Millisecond(Week self) => new Millisecond(self.Value * Week.DayPortion / DayPortion);
        public static implicit operator Millisecond(Day self) => new Millisecond(self.Value / DayPortion);
        public static implicit operator Millisecond(Hour self) => new Millisecond(self.Value * Hour.DayPortion / DayPortion);
        public static implicit operator Millisecond(Minute self) => new Millisecond(self.Value * Minute.DayPortion / DayPortion);
        public static implicit operator Millisecond(Second self) => new Millisecond(self.Value * Second.DayPortion / DayPortion);
    }
}
