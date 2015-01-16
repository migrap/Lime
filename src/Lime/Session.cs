using System;
using System.Collections.Generic;

namespace Lime {
    public class Session {
        public Guid Id { get; }

        public Identity From { get; set; }

        public Identity Procuration { get; set; }

        public Identity To { get; set; }

        public IDictionary<string, string> Metadata { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public State State { get; set; }

        public Reason Reason { get; set; }
    }
}