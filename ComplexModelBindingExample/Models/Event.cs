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
        [Display(Name = "Event Title:")]
        public string EventTitle { get; set; }

        [Display(Name = "Hosted By:")]
        public string EventBy { get; set; }

        // Pass down a list of Categories from the database. 
        // Grab all the Event Types and show them on the web page.
        [Display(Name ="Category")]
        public List<EventType>? AllCategories { get; set; }

        // The chosen event 
        public int ChosenEvent { get; set; }
    
    }

    public class EventIndexViewModel
    { 
        public int EventId { get; set; }

        [Display(Name = "Category")]
        public string EventType { get; set; }

        [Display(Name = "Event Title")]
        public string EventTitle { get; set; }

        [Display(Name = "Host(s)")]
        public string EventBy { get; set; }
    }
}
