namespace SystemOfUnits.Time {
    public partial struct Year {
        internal const double DayPortion = /* ~365.2425 */ 146_097d / 400d;

        public static implicit operator Year(Month self) => new Year(self.Value * Month.DayPortion / DayPortion);
        public static implicit operator Year(Week self) => new Year(self.Value * Week.DayPortion / DayPortion);
        public static implicit operator Year(Day self) => new Year(self.Value / DayPortion);
        public static implicit operator Year(Hour self) => new Year(self.Value * Hour.DayPortion / DayPortion);
        public static implicit operator Year(Minute self) => new Year(self.Value * Minute.DayPortion / DayPortion);
        public static implicit operator Year(Second self) => new Year(self.Value * Second.DayPortion / DayPortion);
        public static implicit operator Year(Millisecond self) => new Year(self.Value * Millisecond.DayPortion / DayPortion);
    }
}
