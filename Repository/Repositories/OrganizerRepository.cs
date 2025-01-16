using Repository.Entity;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class OrganizerRepository:IRepository<Organizer>
    {
        private readonly IContext context;
        public OrganizerRepository(IContext context)
        {
            this.context = context;
        }

        public Organizer Add(Organizer item)
        {
            context.Organizers.Add(item);
            context.save();
            return item;
        }

        public void Delete(string id)
        {
            context.Organizers.Remove(Get(id));
            context.save();
        }

        public Organizer Get(string id)
        {
            return context.Organizers.FirstOrDefault(x => x.id == id);
        }

        public List<Organizer> GetAll()
        {
            return context.Organizers.ToList();
        }

        public Organizer Update(string id, Organizer item)
        {
            throw new NotImplementedException();
        }
    }
}
