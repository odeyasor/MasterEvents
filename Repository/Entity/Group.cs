﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Group
    {
        public string id { get; set; }
        public string name { get; set; }
        public string organizerId { get; set; }
        public string guestId { get; set; }
    }
}
