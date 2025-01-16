using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class GuestInEvent
    {
        public string id { get; set; }
        public string guestId { get; set; }
        public string eventId { get; set; }
        public bool ok { get; set; }
        public Category category { get; set; }
    }
}
