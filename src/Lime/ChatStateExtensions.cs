using System;

namespace Lime {
    public static partial class ChatStateExtensions {

        public static void State(this ChatState chatstate, Func<ChatStateExtension<State>, Func<State>> state) {
            chatstate.State = state(null)();
        }
    }

    public static partial class ChatStateExtensions {
        private static readonly State _starting = new State("starting");
        private static readonly State _composing = new State("composing");
        private static readonly State _paused = new State("paused");
        private static readonly State _deleting = new State("deleting");
        private static readonly State _gone = new State("gone");

        public static State Starting(this ChatStateExtension<State> chatstate) {
            return _starting;
        }

        public static State Composing(this ChatStateExtension<State> chatstate) {
            return _composing;
        }

        public static State Paused(this ChatStateExtension<State> chatstate) {
            return _paused;
        }

        public static State Deleting(this ChatStateExtension<State> chatstate) {
            return _deleting;
        }

        public static State Gone(this ChatStateExtension<State> chatstate) {
            return _gone;
        }
    }
}