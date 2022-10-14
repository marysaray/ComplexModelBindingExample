using System.ComponentModel.DataAnnotations;

namespace ComplexModelBindingExample.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public string EventTitle { get; set; }

        public string EventBy { get; set; }

        public EventType Category { get; set; }

    }
}
