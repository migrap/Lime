using System;
using System.Collections.Generic;

namespace Lime {
    public class Command : Envelope { 
        public virtual Method Method { get; set; }

        public virtual Uri Uri { get; set; }

        public virtual Type Type { get; set; }

        public virtual object Resource { get; set; }

        public virtual Status Status { get; set; }

        public virtual Reason Reason { get; set; }
    }
}
