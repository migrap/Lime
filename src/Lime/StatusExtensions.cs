﻿namespace Lime {
    public static class StatusExtensions {
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