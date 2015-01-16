namespace Lime {
    public static class StateExtensions {
        private static readonly State _new = new State("new");
        private static readonly State _negotiating = new State("negotiating");
        private static readonly State _authenticating = new State("authenticating");
        private static readonly State _established = new State("established");
        private static readonly State _finishing = new State("finishing");
        private static readonly State _finished = new State("finished");
        private static readonly State _failed = new State("failed");

        public static State New(this Session command) {
            return _new;
        }

        public static State Negotiating(this Session command) {
            return _negotiating;
        }

        public static State Authenticating(this Session command) {
            return _authenticating;
        }

        public static State Established(this Session command) {
            return _established;
        }

        public static State Finishing(this Session command) {
            return _finishing;
        }

        public static State Finished(this Session command) {
            return _finished;
        }

        public static State Failed(this Session command) {
            return _failed;
        }
    }
}