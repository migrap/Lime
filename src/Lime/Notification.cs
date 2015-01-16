namespace Lime {
    public class Notification : Envelope {
        public Event Event { get; set; }

        public Reason Reason { get; set; }        
    }
}
