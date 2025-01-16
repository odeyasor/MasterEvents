using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    
    public class SubGuest
    {
        public string id { get; set; }
        public string guestId { get; set; }
        public string name { get; set; }
        public Gender gender { get; set; }

    }
}
