using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Entity;
using Domain.Repositories;
using Domain.Services;

namespace Application.Services
{
    class EventService : BaseService<Event>, IEventService
    {

        private readonly IBaseRepository<Event> baseRepository;

        public EventService(IBaseRepository<Event> baseRepository) : base(baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public bool Event(Event objEvent)
        {
            this.baseRepository.Create(objEvent);
            this.baseRepository.Save();

            return true;
        }
    }
}
