using System;

namespace Lime {
    public static class SessionExtensions {
        public static void State(this Session session, Func<Session, State> state) {
            session.State = state(session);
        }

        public static void Reason(this Session session, Func<Session, Reason> reason) {
            session.Reason = reason(session);
        }
    }
}