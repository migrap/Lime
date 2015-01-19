using System;
using System.Collections.Generic;

namespace Lime {
    public class Envelope {
        public Guid Id { get; set; }

        public Node From { get; set; }

        public Node Procuration { get; set; }

        public Node To { get; set; }

        public IDictionary<string, string> Metadata { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    }
}
