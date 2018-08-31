namespace SystemOfUnits.Time {
    public partial struct Week {
        internal const double DayPortion = 7;

        public static implicit operator Week(Year self) => new Week(self.Value * Year.DayPortion / DayPortion);
        public static implicit operator Week(Month self) => new Week(self.Value * Month.DayPortion / DayPortion);
        public static implicit operator Week(Day self) => new Week(self.Value / DayPortion);
        public static implicit operator Week(Hour self) => new Week(self.Value * Hour.DayPortion / DayPortion);
        public static implicit operator Week(Minute self) => new Week(self.Value * Minute.DayPortion / DayPortion);
        public static implicit operator Week(Second self) => new Week(self.Value * Second.DayPortion / DayPortion);
        public static implicit operator Week(Millisecond self) => new Week(self.Value * Millisecond.DayPortion / DayPortion);
    }
}
