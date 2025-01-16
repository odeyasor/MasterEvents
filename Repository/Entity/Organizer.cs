using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Organizer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
        public List<Event> events { get; set; }
        public List<Group> groups { get; set; }
    }
}
