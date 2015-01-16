using System;
using System.Collections.Generic;

namespace Lime {
    public partial class Notification : Envelope {
        public Event Event { get; set; }

        public Reason Reason { get; set; }        
    }
}
