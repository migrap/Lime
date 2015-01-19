using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Lime {
    [DebuggerDisplay("{DebuggerDisplay()}")]
    public class Identity : IEquatable<Identity> {
        protected static readonly Regex Pattern = new Regex("^(?:([^\"&'/:<>@]{1,1023})@)?([^/@]{1,1023})(?:/(.{1,1023}))?$");
        protected readonly string _name;
        protected readonly string _domain;        

        protected Identity(string name, string domain) {
            _name = name;
            _domain = domain;
        }

        public override string ToString() {
            return string.Format("{0}@{1}", _name, _domain);
        }

        public override int GetHashCode() {
            return ToString().GetHashCode();
        }

        public bool Equals(Identity other) {
            if (ReferenceEquals(null, other)) {
                return false;
            }
            if (ReferenceEquals(this, other)) {
                return true;
            }

            return _name.Equals(other._name, StringComparison.OrdinalIgnoreCase) && _domain.Equals(other._domain, StringComparison.OrdinalIgnoreCase);
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

            return Equals((Identity)obj);
        }

        public static Identity Parse(string s) {
            var match = Pattern.Match(s);

            if (match.Success) {
                return new Identity(match.Groups[1].Value, match.Groups[2].Value);
            }

            return null;
        }

        public static bool TryParse(string s, out Identity value) {
            try {
                value = Parse(s);
                return true;
            }
            catch {
                value = null;
                return false;
            }
        }

        private string DebuggerDisplay() {
            return ToString();
        }

        public static implicit operator string (Identity value) {
            return value.ToString();
        }

        public static implicit operator Identity(string value) {
            return Identity.Parse(value);
        }
    }
}
