﻿using Repository.Entity;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class PhotosFromEventRepository:IRepository<PhotosFromEvent>
    {
        private readonly IContext context;
        public PhotosFromEventRepository(IContext context)
        {
            this.context = context;
        }

        public PhotosFromEvent Add(PhotosFromEvent item)
        {
            context.PhotosFromEvents.Add(item);
            context.save();
            return item;
        }

        public void Delete(string id)
        {
            context.PhotosFromEvents.Remove(Get(id));
            context.save();
        }

        public PhotosFromEvent Get(string id)
        {
            return context.PhotosFromEvents.FirstOrDefault(x => x.id == id);
        }

        public List<PhotosFromEvent> GetAll()
        {
            return context.PhotosFromEvents.ToList();
        }

        public PhotosFromEvent Update(string id, PhotosFromEvent item)
        {
            throw new NotImplementedException();
        }
    }
}

