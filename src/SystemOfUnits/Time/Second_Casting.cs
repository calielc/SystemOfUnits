namespace SystemOfUnits.Time {
    public partial struct Second {
        internal const double DayPortion = 1d / (24d * 60d * 60d);

        public static implicit operator Second(Year self) => new Second(self.Value * Year.DayPortion / DayPortion);
        public static implicit operator Second(Month self) => new Second(self.Value * Month.DayPortion / DayPortion);
        public static implicit operator Second(Week self) => new Second(self.Value * Week.DayPortion / DayPortion);
        public static implicit operator Second(Day self) => new Second(self.Value / DayPortion);
        public static implicit operator Second(Hour self) => new Second(self.Value * Hour.DayPortion / DayPortion);
        public static implicit operator Second(Minute self) => new Second(self.Value * Minute.DayPortion / DayPortion);
        public static implicit operator Second(Millisecond self) => new Second(self.Value * Millisecond.DayPortion / DayPortion);
    }
}
