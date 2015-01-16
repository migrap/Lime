namespace Lime {
    public static class ReasonExtensions {
        public static Reason GeneralError(this object self, string description = "") {
            const int code = 1;
            return new Reason(code, description);
        }

        public static Reason SessionError(this object self, string description = "") {
            const int code = 11;
            return new Reason(code, description);
        }

        public static Reason GatewayError(this object self, string description = "") {
            const int code = 81;
            return new Reason(code, description);
        }        
    }
}