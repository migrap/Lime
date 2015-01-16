namespace Lime {
    public class Message : Envelope {
        public Type Type { get; set; }

        public object Content { get; set; }
    }
}
