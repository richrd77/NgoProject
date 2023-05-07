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
    class SignupService : BaseService<User>, ISignupService
    {
        public SignupService(IBaseRepository<User> baseRepository) : base(baseRepository)
        {
        }

        public void Signup()
        {

        }
    }
}
