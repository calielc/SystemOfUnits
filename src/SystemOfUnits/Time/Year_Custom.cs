using System;

namespace SystemOfUnits.Time {
    public partial struct Year {
        public static implicit operator Year(TimeSpan self) => new Year(self.TotalDays / DayPortion);
        public static implicit operator TimeSpan(Year self) => TimeSpan.FromDays(self.Value * DayPortion);
    }
}