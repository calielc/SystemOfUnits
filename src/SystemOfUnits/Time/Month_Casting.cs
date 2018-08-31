namespace SystemOfUnits.Time {
    public partial struct Month {
        internal const double DayPortion = /* ~30.436875 */ 48_699d / 1_600d;

        public static implicit operator Month(Year self) => new Month(self.Value * Year.DayPortion / DayPortion);
        public static implicit operator Month(Week self) => new Month(self.Value * Week.DayPortion / DayPortion);
        public static implicit operator Month(Day self) => new Month(self.Value / DayPortion);
        public static implicit operator Month(Hour self) => new Month(self.Value * Hour.DayPortion / DayPortion);
        public static implicit operator Month(Minute self) => new Month(self.Value * Minute.DayPortion / DayPortion);
        public static implicit operator Month(Second self) => new Month(self.Value * Second.DayPortion / DayPortion);
        public static implicit operator Month(Millisecond self) => new Month(self.Value * Millisecond.DayPortion / DayPortion);
    }
}
