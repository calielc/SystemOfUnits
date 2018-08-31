using System;

namespace SystemOfUnits.Time {
    public partial struct Millisecond {
        public static implicit operator Millisecond(TimeSpan self) => new Millisecond(self.TotalMilliseconds);
        public static implicit operator TimeSpan(Millisecond self) => TimeSpan.FromMilliseconds(self.Value);
    }
}