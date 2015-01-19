using System;

namespace Lime {
    public class Presence {
        public Status Status { get; set; }
        public string Message { get; set; }
        public RoutingRule RoutingRule { get; set; }
        public int Priority { get; set; }
        public string[] Instances { get; set; }
    }
}