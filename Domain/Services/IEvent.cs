using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Entity;

namespace Domain.Services
{
    public interface IEventService : IBaseService<Event>
    {
        bool Event(Event objevent);
    }
}
