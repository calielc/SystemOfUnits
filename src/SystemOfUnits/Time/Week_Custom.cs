using System;

namespace SystemOfUnits.Time {
    public partial struct Week {
        public static implicit operator Week(TimeSpan self) => new Week(self.TotalDays / DayPortion);
        public static implicit operator TimeSpan(Week self) => TimeSpan.FromDays(self.Value * DayPortion);
    }
}