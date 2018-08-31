using System;

namespace SystemOfUnits.Time {
    public partial struct Minute {
        public static implicit operator Minute(TimeSpan self) => new Minute(self.TotalMinutes);
        public static implicit operator TimeSpan(Minute self) => TimeSpan.FromMinutes(self.Value);
    }
}