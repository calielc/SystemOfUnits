using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;
using SystemOfUnits.Angle;
using SystemOfUnits.DigitalInformation.Bit;
using SystemOfUnits.DigitalInformation.Byte;
using SystemOfUnits.Length.Imperial;
using SystemOfUnits.Length.Metre;
using SystemOfUnits.Others;
using SystemOfUnits.Temperature;
using SystemOfUnits.Time;

namespace Samples {
    internal class Program {
        private static void Main(string[] args) {
            {
                var bits = new Bit(8);
                var bytes = (SystemOfUnits.DigitalInformation.Byte.Byte)bits * 3000;
                var kilobyte = (Kilobyte)bytes;
                var kibibyte = (Kibibyte)bytes;
                var yottabyte = (Yottabyte)bytes;
            }

            {
                var metre12 = (Metre)12;
                var metre15 = (Metre)15;

                foreach (var item in new[] { metre12, metre15 }.OrderByDescending(x => x)) {
                    Console.WriteLine(item);
                }
                Console.WriteLine();

                foreach (var item in new[] { metre12, metre15 }.OrderBy(x => x)) {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

            {
                var degree = Degree.Degrees45;
                Radian radian = degree;
            }

            {
                var mile = (Mile)2d;
                Inch inch = mile;
                Foot foot = mile;
            }

            {
                var inch = (Inch)2d;
                Mile mile = inch;
                Foot foot = inch;
            }
            {
                var kelvin = new Kelvin(15);
                var fahrenheit = new Fahrenheit(7);
                var celsius = new Celsius(35);

                foreach (var temperature in new ITemperatureUnit[] { kelvin, fahrenheit, celsius }) {
                    Console.WriteLine($"{temperature}, to Kelvin: {temperature.ToKelvin()}");
                }

                Console.WriteLine();
            }

            {
                var a = (Metre)2;
                var b = (Metre)5;
                var c = (Metre)7;
                var area = a * b;
                var volume = area * c;
            }

            {
                var hours = (Hour)2.5;
                var minutes = (Minute)hours;
                var seconds = (Second)hours;
            }

            {
                var day = new Day(258);
                var percentage = new Percentage(10);
            }

            {
                var foo = new Foo { Age = (Month)365, Distance = (Metre)10 };
                var serialized = JsonConvert.SerializeObject(foo);
                var deserialized = JsonConvert.DeserializeObject<Foo>(serialized);
            }

            {
                var foo = new Foo { Age = (Month)365, Distance = (Metre)10 };

                var xmlSerializer = new XmlSerializer(foo.GetType());
                using (var textWriter = new StringWriter()) {
                    xmlSerializer.Serialize(textWriter, foo);
                    var serialized = textWriter.ToString();
                }
            }
        }
    }

    public struct Foo {
        public Year Age { get; set; }
        public Kilometre Distance { get; set; }
        public Celsius? Temperature { get; set; }
    }
}
