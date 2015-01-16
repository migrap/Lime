using System;
using System.Collections.Generic;

namespace Lime {
    public class Message : Envelope {
        public string Type { get; set; }

        public object Content { get; set; }
    }
}
