using System.Linq;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.Generators;
using SystemOfUnitsGenerator.GeneratorsCurrency.Builders;

namespace SystemOfUnitsGenerator.GeneratorsCurrency {
    internal class CurrencyGenerator : IGenerator {
        private static readonly NamespaceDefinition NamespaceCode = NamespaceDefinition.SystemOfUnits + Resource.NamespaceCurrency;
        private static readonly NamespaceDefinition NamespaceTest = NamespaceDefinition.SystemOfUnitsTests + Resource.NamespaceCurrency;

        public IContentFileBuilderCollection Generate() {
            var contexts = new[]
            {
                (description: "United States dollar", name: "USD", symbol: "US$"),
                (description: "Euro", name: "EUR", symbol: "€"  ),
                (description: "Japonese yen", name: "JPY", symbol: "¥"  ),
                (description: "Pound sterling", name: "GBP", symbol: "£"  ),
                (description: "Australian dollar", name: "AUD", symbol: "A$" ),
                (description: "Canadian dollar", name: "CAD", symbol: "C$" ),
                (description: "Swiss franc", name: "CHF", symbol: "Fr" ),
                (description: "Renminbi", name: "CNY", symbol: "元" ),
                (description: "Swedish krona", name: "SEK", symbol: "kr" ),
                (description: "New Zealand dollar", name: "NZD", symbol: "NZ$"),
                (description: "Mexican peso", name: "MXN", symbol: "$"   ),
                (description: "Singapore dollar", name: "SGD", symbol: "$$"  ),
                (description: "Hong Kong dollar", name: "HKD", symbol: "HK$" ),
                (description: "Norwegian krone", name: "NOK", symbol: "kr" ),
                (description: "South Korean won", name: "KRW", symbol: "₩" ),
                (description: "Turkish lira", name: "TRY", symbol: "₺" ),
                (description: "Russian ruble", name: "RUB", symbol: "₽" ),
                (description: "Indian rupee", name: "INR", symbol: "₹" ),
                (description: "Brazilian real", name: "BRL", symbol: "R$"),
                (description: "South African rand", name: "ZAR", symbol: "R" ),
            }.Select(tuple => new Context(
                namespaceCode: NamespaceCode,
                namespaceTest: NamespaceTest,
                name: tuple.name,
                symbol: tuple.symbol,
                xmlDoc: new XmlDoc($"Represents a {tuple.description} (code: {tuple.name} and symbol {tuple.symbol})")
            ));

            return new ClassesBuilder(contexts);
        }
    }
}