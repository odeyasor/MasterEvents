using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Event
    {
        public string id { get; set; }//בודקת אם זה עובד
        public string organizerId { get; set; }
        public string eventName { get; set; }
        public DateTime eventDate { get; set; }
        public string address { get; set; }
        public string details { get; set; }
        public bool seperation { get; set; }
        public string invitation { get; set; }
        public List<PhotosFromEvent> photos { get; set; }
        public List<GuestInEvent> guests { get; set; }
    }
}
