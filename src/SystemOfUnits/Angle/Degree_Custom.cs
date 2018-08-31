using System;

namespace SystemOfUnits.Angle {
    public partial struct Degree {
        private const double FullLoop = 360d;

        public Degree Normalize() {
            var angle = Value;
            if (angle >= 0d && angle < FullLoop) {
                return this;
            }

            if (angle < 0d) {
                angle = FullLoop + angle % -FullLoop;
            }

            angle = angle % FullLoop;
            return new Degree(angle);
        }

        public double Sin() => Math.Sin(Value * RadianRatio);
        public double Cos() => Math.Cos(Value * RadianRatio);
        public double Tan() => Math.Tan(Value * RadianRatio);
        public double Acos() => Math.Acos(Value * RadianRatio);
        public double Asin() => Math.Asin(Value * RadianRatio);
        public double Atan() => Math.Atan(Value * RadianRatio);

        public static readonly Degree Degrees0 = new Degree(0d);
        public static readonly Degree Degrees30 = new Degree(30d);
        public static readonly Degree Degrees45 = new Degree(45d);
        public static readonly Degree Degrees60 = new Degree(60d);
        public static readonly Degree Degrees90 = new Degree(90d);
        public static readonly Degree Degrees180 = new Degree(180d);
        public static readonly Degree Degrees270 = new Degree(270d);
    }
}