using System;
using System.Collections.Generic;

namespace Lime {
    public class Contact : IEquatable<Contact> {
        public Contact() {
        }

        public Contact(string identity, string name = "") {
            Identity = identity;
            Name = name;
        }

        public string Identity { get; set; } = "";

        public string Name { get; set; } = "";

        public bool Equals(Contact other) {
            if (other == null) {
                return false;
            }
            return Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase) && Identity.Equals(other.Identity, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }
            if (ReferenceEquals(this, obj)) {
                return true;
            }
            if (obj.GetType() != GetType()) {
                return false;
            }
            return Equals(obj as Contact);
        }

        public override int GetHashCode() {
            unchecked {
                return Identity.GetHashCode() ^ Name.GetHashCode();
            }
        }
    }

    public class ContactEqualityComparer : IEqualityComparer<Contact> {
        public static IEqualityComparer<Contact> Default { get; } = new ContactEqualityComparer();

        public bool Equals(Contact x, Contact y) {
            return x.Equals(y);
        }

        public int GetHashCode(Contact obj) {
            return obj.GetHashCode();
        }
    }
}