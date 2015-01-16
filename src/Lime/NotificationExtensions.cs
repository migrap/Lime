using System;

namespace Lime {
    public static class NotificationExtensions {        
        public static void Event(this Notification notification, Func<Notification,Event> @event){
            notification.Event = @event(notification);
        }

        public static void Reason(this Notification notification, Func<Notification,Reason> reason) {
            notification.Reason = reason(notification);
        }
    }
}