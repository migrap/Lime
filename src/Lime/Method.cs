using System;
using System.Diagnostics;

namespace Lime {
    [DebuggerDisplay("{DebuggerDisplay()}")]
    public sealed class Method :IEquatable<Method> {
        private readonly string _value;

        public Method(string value) {
            _value = value;
        }

        public static implicit operator string(Method value) {
            return value._value;
        }

        public static implicit operator Method(string value) {
            return new Method(value);
        }

        private string DebuggerDisplay() {
            return _value;
        }

        public override int GetHashCode() {
            return _value.ToLower().GetHashCode();
        }

        public bool Equals(Method other) {
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

            return Equals((Method)obj);
        }
    }
}
