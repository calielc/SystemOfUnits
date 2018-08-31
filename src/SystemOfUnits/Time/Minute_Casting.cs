namespace SystemOfUnits.Time {
    public partial struct Minute {
        internal const double DayPortion = 1d / (24d * 60d);

        public static implicit operator Minute(Year self) => new Minute(self.Value * Year.DayPortion / DayPortion);
        public static implicit operator Minute(Month self) => new Minute(self.Value * Month.DayPortion / DayPortion);
        public static implicit operator Minute(Week self) => new Minute(self.Value * Week.DayPortion / DayPortion);
        public static implicit operator Minute(Day self) => new Minute(self.Value / DayPortion);
        public static implicit operator Minute(Hour self) => new Minute(self.Value * Hour.DayPortion / DayPortion);
        public static implicit operator Minute(Second self) => new Minute(self.Value * Second.DayPortion / DayPortion);
        public static implicit operator Minute(Millisecond self) => new Minute(self.Value * Millisecond.DayPortion / DayPortion);
    }
}
