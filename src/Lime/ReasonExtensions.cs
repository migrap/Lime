namespace Lime {
    public static class ReasonExtensions {
        private static readonly int General = 1;
        private static readonly int Session = 11;
        private static readonly int Gateway = 81;

        public static Reason GeneralError(this CommandExtension<Reason> self, string description = "") {
            return new Reason(General, description);
        }

        public static Reason SessionError(this CommandExtension<Reason> self, string description = "") {
            return new Reason(Session, description);
        }

        public static Reason GatewayError(this CommandExtension<Reason> self, string description = "") {
            return new Reason(Gateway, description);
        }
    }
}