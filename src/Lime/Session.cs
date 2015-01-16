namespace Lime {
    public class Session : Envelope {

        public State State { get; set; }

        public Reason Reason { get; set; }
    }
}