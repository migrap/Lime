using System;
using System.Diagnostics;

namespace Lime {
    [DebuggerDisplay("{DebuggerDisplay()}")]
    public sealed class Event : IEquatable<Event> {
        private readonly string _value;

        public Event(string value) {
            _value = value;
        }

        public static implicit operator string (Event value) {
            return value._value;
        }

        public static implicit operator Event(string value) {
            return new Event(value);
        }

        private string DebuggerDisplay() {
            return _value;
        }

        public override int GetHashCode() {
            return _value.ToLower().GetHashCode();
        }

        public bool Equals(Event other) {
            if(ReferenceEquals(null, other)) {
                return false;
            }
            if(ReferenceEquals(this, other)) {
                return true;
            }

            return string.Equals(this, other, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj) {
            if(ReferenceEquals(null, obj)) {
                return false;
            }
            if(ReferenceEquals(this, obj)) {
                return true;
            }
            if(obj.GetType() != this.GetType()) {
                return false;
            }

            return Equals((Event)obj);
        }
    }
}