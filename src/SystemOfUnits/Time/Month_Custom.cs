using System;

namespace SystemOfUnits.Time {
    public partial struct Month {
        public static implicit operator Month(TimeSpan self) => new Month(self.TotalDays / DayPortion);
        public static implicit operator TimeSpan(Month self) => TimeSpan.FromDays(self.Value * DayPortion);
    }
}