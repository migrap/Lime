//using System;
//using System.Diagnostics;

//namespace Lime {
//    [DebuggerDisplay("{DebuggerDisplay()}")]
//    public class Uri : IEquatable<Uri> {        
//        private string _value;

//        private Uri(string value) {
//            _value = value;
//        }

//        private string DebuggerDisplay() {
//            return string.Format("{0}", _value);
//        }

//        public override int GetHashCode() {
//            return _value.ToLower().GetHashCode();
//        }

//        public static implicit operator string (Uri value) {
//            return value._value;
//        }

//        public static implicit operator Uri(string value) {
//            return new Uri(value);
//        }

//        public bool Equals(Uri other) {
//            if (ReferenceEquals(null, other)) {
//                return false;
//            }
//            if (ReferenceEquals(this, other)) {
//                return true;
//            }

//            return _value.Equals(other._value, StringComparison.OrdinalIgnoreCase);
//        }

//        public override bool Equals(object obj) {
//            if (ReferenceEquals(null, obj)) {
//                return false;
//            }
//            if (ReferenceEquals(this, obj)) {
//                return true;
//            }
//            if (obj.GetType() != this.GetType()) {
//                return false;
//            }

//            return Equals((Uri)obj);
//        }
//    }
//}
