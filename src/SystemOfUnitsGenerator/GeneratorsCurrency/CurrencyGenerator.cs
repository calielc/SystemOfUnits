using System.Linq;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.GeneratorsCurrency.Builders;

namespace SystemOfUnitsGenerator.GeneratorsCurrency {
    internal class CurrencyGenerator : IGenerator {
        public IContentFileBuilderCollection Generate() {
            var currencies = new (string name, string code, string symbol)[] {
                ("United States dollar", "USD", "US$"),
                ("Euro", "EUR", "€"),
                ("Japonese yen", "JPY", "¥"),
                ("Pound sterling", "GBP", "£"),
                ("Australian dollar", "AUD", "A$"),
                ("Canadian dollar", "CAD", "C$"),
                ("Swiss franc", "CHF", "Fr"),
                ("Renminbi", "CNY", "元"),
                ("Swedish krona", "SEK", "kr"),
                ("New Zealand dollar", "NZD", "NZ$"),
                ("Mexican peso", "MXN", "$"),
                ("Singapore dollar", "SGD", "$$"),
                ("Hong Kong dollar", "HKD", "HK$"),
                ("Norwegian krone", "NOK", "kr"),
                ("South Korean won", "KRW", "₩"),
                ("Turkish lira", "TRY", "₺"),
                ("Russian ruble", "RUB", "₽"),
                ("Indian rupee", "INR", "₹"),
                ("Brazilian real", "BRL", "R$"),
                ("South African rand", "ZAR", "R")
            };

            var namespaces = new UnitNamespaces(Resource.NamespaceCurrency);
            var contexts = currencies.Select(tuple => {
                var unitDefinition = new UnitDefinition(
                    name: tuple.code,
                    symbol: tuple.symbol,
                    summary: $"Represents a {tuple.name} (code: {tuple.code} and symbol {tuple.symbol})"
                );
                return namespaces + unitDefinition;
            });

            return new ClassesBuilder(contexts);
        }
    }
}