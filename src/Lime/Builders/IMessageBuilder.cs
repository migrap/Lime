
using System;

namespace Lime.Builders {
    public interface IMessageBuilder : IBuilder<Message> {
        IMessageBuilder Id(Guid value);
        IMessageBuilder From(Node value);
        IMessageBuilder To(Node value);
        IMessageBuilder Procuration(Node value);
        IMessageBuilder Type(MediaType value);
        IMessageBuilder Content(object value);
    }
}
