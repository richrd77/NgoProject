using Domain.Models.Entity;
using Domain.Repositories;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    class DonarService : BaseService<Money>, IDonorService
    {

        private readonly IBaseRepository<Money> baseRepository;

        public DonarService(IBaseRepository<Money> baseRepository) : base(baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public bool Donate(Money objMoney)
        {
            this.baseRepository.Create(objMoney);
            this.baseRepository.Save();

            return true;
        }
    }
}
