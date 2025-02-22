﻿using Repository.Entity;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class SeatingRepository
    {
        private readonly IContext context;
        public SeatingRepository(IContext context)
        {
            this.context = context;
        }

        public Seating Add(Seating item)
        {
            context.Seatings.Add(item);
            context.save();
            return item;
        }

        public void Delete(string id)
        {
            context.Seatings.Remove(Get(id));
            context.save();
        }

        public Seating Get(string id)
        {
            return context.Seatings.FirstOrDefault(x => x.id == id);
        }

        public List<Seating> GetAll()
        {
            return context.Seatings.ToList();
        }

        public Seating Update(string id, Seating item)
        {
            throw new NotImplementedException();
        }
    }
}
