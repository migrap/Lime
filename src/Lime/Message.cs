namespace Lime {
    public class Message : Envelope {
        public MediaType Type { get; set; }

        public object Content { get; set; }
    }
}
