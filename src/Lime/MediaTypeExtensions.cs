using System;

namespace Lime {
    public static class MediaTypeExtensions {
        private static readonly MediaType _presence = new MediaType("application/vnd.lime.presence+json");

        public static MediaType Presence(this MessageExtension<MediaType> message) {
            return _presence;
        }
    }
}