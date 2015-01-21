using System;

namespace Lime {
    public static partial class PresenceExtensions {
        public static void Status(this Presence presence, Func<PresenceExtension<Status>, Func<Status>> status) {
            presence.Status = status(null)();
        }

        public static void Priority(this Presence presence, Func<PresenceExtension<int>, Func<int>> priority) {
            presence.Priority = priority(null)();
        }
    }
}