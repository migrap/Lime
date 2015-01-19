using System;

namespace Lime {
    public static class SessionExtensions {
        public static void State(this Session session, Func<SessionExtension<State>, Func<State>> state) {
            session.State = state(null)();
        }

        public static void Reason(this Session session, Func<SessionExtension<Reason>, Func<string, Reason>> reason, string description = "") {
            session.Reason = reason(null)(description);
        }
    }
}