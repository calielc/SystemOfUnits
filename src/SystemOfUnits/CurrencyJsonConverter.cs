using System;
using Newtonsoft.Json;

namespace SystemOfUnits {
    public sealed class CurrencyJsonConverter : JsonConverter<ICurrency> {
        public override void WriteJson(JsonWriter writer, ICurrency currency, JsonSerializer serializer) {
            writer.WriteValue(currency.Value);
        }

        public override ICurrency ReadJson(JsonReader reader, Type objectType, ICurrency existingValue, bool hasExistingValue, JsonSerializer serializer) {
            if (reader.Value is null) {
                return null;
            }

            var value = (decimal)reader.Value;
            var instance = Activator.CreateInstance(objectType, value);

            return (ICurrency)instance;
        }
    }
}