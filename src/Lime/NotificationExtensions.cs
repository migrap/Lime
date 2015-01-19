using System;

namespace Lime {
    public static class NotificationExtensions {
        public static void Event(this Notification notification, Func<NotificationExtension<Event>, Func<Event>> @event) {
            notification.Event = @event(null)();
        }

        public static void Reason(this Notification command, Func<NotificationExtension<Reason>, Func<string, Reason>> reason, string description = "") {
            command.Reason = reason(null)(description);
        }
    }
}