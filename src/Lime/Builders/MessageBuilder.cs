using System;

namespace Lime.Builders {
    public class MessageBuilder : IMessageBuilder, IBuilder<Message> {
        private Message _message = new Message();
        public IMessageBuilder Content(object value) {
            _message.Content = value;
            return this;
        }

        public IMessageBuilder From(Node value) {
            _message.From = value;
            return this;
        }

        public IMessageBuilder Id(Guid value) {
            _message.Id = value;
            return this;
        }

        public IMessageBuilder Procuration(Node value) {
            _message.Procuration = value;
            return this;
        }

        public IMessageBuilder To(Node value) {
            _message.To = value;
            return this;
        }

        public IMessageBuilder Type(MediaType value) {
            _message.Type = value;
            return this;
        }

        public Message Build() {
            return _message;
        }
    }
}
