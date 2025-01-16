using Repository.Entity;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GuestInEventRepository:IRepository<GuestInEvent>
    {
        private readonly IContext context;
        public GuestInEventRepository(IContext context)
        {
            this.context = context;
        }

        public GuestInEvent Add(GuestInEvent item)
        {
            context.GuestInEvents.Add(item);
            context.save();
            return item;
        }

        public void Delete(string id)
        {
            context.GuestInEvents.Remove(Get(id));
            context.save();
        }

        public GuestInEvent Get(string id)
        {
            return context.GuestInEvents.FirstOrDefault(x => x.id == id);
        }

        public List<GuestInEvent> GetAll()
        {
            return context.GuestInEvents.ToList();
        }

        public GuestInEvent Update(string id, GuestInEvent item)
        {
            throw new NotImplementedException();
        }
    }
}
