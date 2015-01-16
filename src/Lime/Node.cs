using System;
using System.Text.RegularExpressions;

namespace Lime {
    public class Node : Identity, IEquatable<Node> {
        private readonly string _instance;

        private Node(string name, string domain, string instnace) : base(name, domain) {
            _instance = instnace;
        }

        public override string ToString() {
            return string.Format("{0}/{1}", base.ToString(), _instance);
        }

        public bool Equals(Node other) {
            if (ReferenceEquals(null, other)) {
                return false;
            }
            if (ReferenceEquals(this, other)) {
                return true;
            }

            return base.Equals(other) && _instance.Equals(other._instance, StringComparison.OrdinalIgnoreCase);
        }

        new public static Node Parse(string s) {
            var match = Pattern.Match(s);

            if (match.Success) {
                return new Node(match.Groups[0].Value, match.Groups[1].Value, match.Groups[2].Value);
            }

            return null;
        }

        public static bool TryParse(string s, out Node value) {
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

        public static implicit operator string (Node value) {
            return value.ToString();
        }

        public static implicit operator Node(string value) {
            return Node.Parse(value);
        }
    }
}