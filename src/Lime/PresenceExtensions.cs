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

    public static partial class PresenceExtensions {
        private static readonly Status _unavailable = new Status("unavailable");
        private static readonly Status _available = new Status("available");
        private static readonly Status _busy = new Status("busy");
        private static readonly Status _away = new Status("away");

        public static Status Unavailable(this PresenceExtension<Status> presence) {
            return _unavailable;
        }

        public static Status Available(this PresenceExtension<Status> presence) {
            return _available;
        }

        public static Status Busy(this PresenceExtension<Status> presence) {
            return _busy;
        }

        public static Status Away(this PresenceExtension<Status> presence) {
            return _away;
        }
    }
}