using System;
using System.Collections.Generic;
using System.Linq;

namespace SystemOfUnitsGenerator.Common {
    internal class XmlDoc {
        public XmlDoc(string summary) {
            Summary = summary.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToReadOnlyList();
        }

        public IReadOnlyList<string> Summary { get; }
    }
}