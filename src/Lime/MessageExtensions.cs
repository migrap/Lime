using System;

namespace Lime {
    public static class MessageExtensions {
        public static void Type(this Message message, Func<Message, Type> type) {
            message.Type = type(message);
        }
    }
}