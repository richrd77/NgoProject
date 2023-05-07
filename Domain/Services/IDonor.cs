using Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IDonorService : IBaseService<Money>
    {
        bool Donate(Money money);
    }
}
