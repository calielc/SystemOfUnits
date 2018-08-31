using System;

namespace SystemOfUnits.Time {
    public partial struct Day {
        public static implicit operator Day(TimeSpan self) => new Day(self.TotalDays);
        public static implicit operator TimeSpan(Day self) => TimeSpan.FromDays(self.Value);
    }
}