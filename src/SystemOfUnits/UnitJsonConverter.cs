using System;
using Newtonsoft.Json;

namespace SystemOfUnits
{
    public sealed class UnitJsonConverter : JsonConverter<IUnit>
    {
        public override void WriteJson(JsonWriter writer, IUnit unit, JsonSerializer serializer)
        {
            writer.WriteValue(unit.Value);
        }

        public override IUnit ReadJson(JsonReader reader, Type objectType, IUnit existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.Value is null)
            {
                return null;
            }

            var value = (double)reader.Value;
            var instance = Activator.CreateInstance(objectType, value);

            return (IUnit)instance;
        }
    }
}