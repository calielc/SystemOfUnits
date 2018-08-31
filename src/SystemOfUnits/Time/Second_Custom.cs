using System;

namespace SystemOfUnits.Time {
    public partial struct Second {
        public static implicit operator Second(TimeSpan self) => new Second(self.TotalSeconds);
        public static implicit operator TimeSpan(Second self) => TimeSpan.FromSeconds(self.Value);
    }
}