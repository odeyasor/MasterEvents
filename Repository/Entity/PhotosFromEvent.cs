using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class PhotosFromEvent
    {
        public string id { get; set; } 
        public string idEvent { get; set; }
        public string guestId { get; set; }
        public string imageUrl { get; set; }
        public string blessing { get; set; }
    }
}
