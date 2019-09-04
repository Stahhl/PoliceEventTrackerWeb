using System.Collections.Generic;

namespace PoliceEventTrackerWeb.Domain.Models
{
    public class Location
    {
        public Location()
        {
            Events = new List<Event>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Event> Events { get; set; }
    }
}
