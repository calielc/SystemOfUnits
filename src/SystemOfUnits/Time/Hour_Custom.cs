using System;

namespace SystemOfUnits.Time {
    public partial struct Hour {
        public static implicit operator Hour(TimeSpan self) => new Hour(self.TotalHours);
        public static implicit operator TimeSpan(Hour self) => TimeSpan.FromHours(self.Value);
    }
}