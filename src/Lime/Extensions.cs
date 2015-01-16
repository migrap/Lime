using System;
using System.Text.RegularExpressions;

namespace Lime {
    public static partial class Extensions {
        internal static void MatchOrThrow(this Regex regex, string value) {
            if (false == regex.IsMatch(value)) {
                throw new ArgumentException();
            }
        }
    }
}
