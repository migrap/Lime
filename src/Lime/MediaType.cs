using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Lime {
    [DebuggerDisplay("{DebuggerDisplay()}")]
    public class MediaType : IEquatable<MediaType> {
        private static readonly Regex Pattern = new Regex(@"(?P<main>\w+|\*)/(?P<sub>\w+|\*)(\s*;\s*(?P<param>\w+)=\s*=\s*(?P<val>\S+))?");
        private string _value;

        public MediaType(string value) {
            //Pattern.MatchOrThrow(value);
            _value = value;
        }

        private string DebuggerDisplay() {
            return string.Format("{0}", _value);
        }

        public override int GetHashCode() {
            return _value.ToLower().GetHashCode();
        }

        public static implicit operator string(MediaType value) {
            return value._value;
        }

        public static implicit operator MediaType(string value) {
            return new MediaType(value);
        }

        public bool Equals(MediaType other) {
            if (ReferenceEquals(null, other)) {
                return false;
            }
            if (ReferenceEquals(this, other)) {
                return true;
            }

            return _value.Equals(other._value, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }
            if (ReferenceEquals(this, obj)) {
                return true;
            }
            if (obj.GetType() != this.GetType()) {
                return false;
            }

            return Equals((MediaType)obj);
        }
    }
}
