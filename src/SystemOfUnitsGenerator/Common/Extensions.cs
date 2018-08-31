using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SystemOfUnitsGenerator.Common {
    internal static class Extensions {
        public static string ToCamelCase(this string self) {
            if (string.IsNullOrWhiteSpace(self)) {
                return self;
            }

            var first = self[0].ToString().ToUpper();
            return first + self.Substring(1);
        }

        public static string ToLowerCamelCase(this string self) {
            if (string.IsNullOrWhiteSpace(self)) {
                return self;
            }

            var first = self[0].ToString().ToLower();
            return first + self.Substring(1);
        }

        public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> self) => new LazyList<T>(self);

        private sealed class LazyList<T> : IReadOnlyList<T> {
            private readonly Lazy<IReadOnlyList<T>> _lazyList;

            public LazyList(IEnumerable<T> items) {
                _lazyList = new Lazy<IReadOnlyList<T>>(items.ToList);
            }

            public IEnumerator<T> GetEnumerator() => _lazyList.Value.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => _lazyList.Value.GetEnumerator();

            public int Count => _lazyList.Value.Count;

            public T this[int index] => _lazyList.Value[index];
        }
    }
}