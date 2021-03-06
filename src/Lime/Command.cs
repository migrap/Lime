﻿using System;

namespace Lime {
    public class Command : Envelope { 
        public virtual Method Method { get; set; }

        public virtual string Uri { get; set; }

        public virtual string Type { get; set; }

        public virtual object Resource { get; set; }

        public virtual Status Status { get; set; }

        public virtual Reason Reason { get; set; }
    }
}
