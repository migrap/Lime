namespace Lime {
    public static class EventExtensions {
        private static readonly Event _accepted = new Event("accepted");
        private static readonly Event _validated = new Event("validated");
        private static readonly Event _authorized = new Event("authorized");
        private static readonly Event _dispatched = new Event("dispatched");
        private static readonly Event _received = new Event("received");
        private static readonly Event _consumed = new Event("consumed");
        private static readonly Event _failed = new Event("failed");

        public static Event Accepted(this Notification notification) {
            return _accepted;
        }

        public static Event Validated(this Notification notification) {
            return _validated;
        }

        public static Event Authorized(this Notification notification) {
            return _authorized;
        }

        public static Event Dispatched(this Notification notification) {
            return _dispatched;
        }

        public static Event Received(this Notification notification) {
            return _received;
        }

        public static Event Consumed(this Notification notification) {
            return _consumed;
        }

        public static Event Failed(this Notification notification) {
            return _failed;
        }
    }

    public interface EventExtension<T> { }
}