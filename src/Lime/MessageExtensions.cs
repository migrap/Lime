using System;

namespace Lime {
    public static class MessageExtensions {
        public static void Type(this Message message, Func<MessageExtension<MediaType>, Func<MediaType>> type) {
            message.Type = type(null)();
        }
    }
}