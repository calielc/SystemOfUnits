namespace SystemOfUnits.Time {
    public partial struct Hour {
        internal const double DayPortion = 1d / 24d;

        public static implicit operator Hour(Year self) => new Hour(self.Value * Year.DayPortion / DayPortion);
        public static implicit operator Hour(Month self) => new Hour(self.Value * Month.DayPortion / DayPortion);
        public static implicit operator Hour(Week self) => new Hour(self.Value * Week.DayPortion / DayPortion);
        public static implicit operator Hour(Day self) => new Hour(self.Value / DayPortion);
        public static implicit operator Hour(Minute self) => new Hour(self.Value * Minute.DayPortion / DayPortion);
        public static implicit operator Hour(Second self) => new Hour(self.Value * Second.DayPortion / DayPortion);
        public static implicit operator Hour(Millisecond self) => new Hour(self.Value * Millisecond.DayPortion / DayPortion);
    }
}
