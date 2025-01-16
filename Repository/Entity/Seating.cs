using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Seating
    {
        public string id { get; set; }
        public string   eventId { get; set; }
        public string subGuestId { get; set; }
        public int table { get; set; }
        public int seat { get; set; }
    }
}
