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

    public class EventCreateViewModel
    { 
        public string EventTitle { get; set; }

        public string EventBy { get; set; }

        // Pass down a list of Categories from the database. 
        // Grab all the Event Types and show them on the web page.
        public List<EventType>? AllCategories { get; set; }

        // The chosen event 
        public int ChosenEvent { get; set; }
    
    }
}
