namespace SystemOfUnits.Time {
    public partial struct Day {
        public static implicit operator Day(Year self) => new Day(self.Value * Year.DayPortion);
        public static implicit operator Day(Month self) => new Day(self.Value * Month.DayPortion);
        public static implicit operator Day(Week self) => new Day(self.Value * Week.DayPortion);
        public static implicit operator Day(Hour self) => new Day(self.Value * Hour.DayPortion);
        public static implicit operator Day(Minute self) => new Day(self.Value * Minute.DayPortion);
        public static implicit operator Day(Second self) => new Day(self.Value * Second.DayPortion);
        public static implicit operator Day(Millisecond self) => new Day(self.Value * Millisecond.DayPortion);
    }
}
