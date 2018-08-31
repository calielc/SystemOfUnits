using System;

namespace SystemOfUnits.Angle {
    public partial struct Radian {
        internal const double FullLoop = Math.PI * 2d;

        public Radian Normalize() {
            var angle = Value;
            if (angle >= 0d && angle < FullLoop) {
                return this;
            }

            if (angle < 0d) {
                angle = FullLoop + angle % -FullLoop;
            }

            angle = angle % FullLoop;
            return new Radian(angle);
        }

        public double Sin() => Math.Sin(Value);
        public double Cos() => Math.Cos(Value);
        public double Tan() => Math.Tan(Value);
        public double Acos() => Math.Acos(Value);
        public double Asin() => Math.Asin(Value);
        public double Atan() => Math.Atan(Value);

        public static readonly Radian Degrees0 = new Radian(0d);
        public static readonly Radian Degrees30 = new Radian(Math.PI / 6d);
        public static readonly Radian Degrees45 = new Radian(Math.PI / 4d);
        public static readonly Radian Degrees60 = new Radian(Math.PI / 3d);
        public static readonly Radian Degrees90 = new Radian(Math.PI / 2d);
        public static readonly Radian Degrees180 = new Radian(Math.PI);
        public static readonly Radian Degrees270 = new Radian(Math.PI * 3d / 2d);
    }
}