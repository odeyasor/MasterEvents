using AutoMapper;
using Repository.Entity;
using Repository.Interfaces;
using Service.Dtos;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class GuestInEventService : IService<GuestInEventDto>
    {

        private readonly IRepository<GuestInEvent> _repository;
        private readonly IMapper _mapper;

        public GuestInEventService(IRepository<GuestInEvent> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public GuestInEventDto Add(GuestInEventDto item)
        {
            return _mapper.Map<GuestInEventDto>(_repository.Add(_mapper.Map<GuestInEvent>(item)));
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        public GuestInEventDto Get(string id)
        {
            return _mapper.Map<GuestInEventDto>(_repository.Get(id));
        }

        public List<GuestInEventDto> GetAll()
        {
            return _mapper.Map<List<GuestInEventDto>>(_repository.GetAll());
        }

        public GuestInEventDto Update(string id, GuestInEventDto item)
        {
            return _mapper.Map<GuestInEventDto>(_repository.Update(id, _mapper.Map<GuestInEvent>(item)));
        }
    }
}
