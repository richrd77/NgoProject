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
    class LoginService : BaseService<User>, ILoginService
    {
        private readonly IBaseRepository<User> baseRepository;

        public LoginService(IBaseRepository<User> baseRepository) : base(baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public Tuple<bool, User> Login(string userName, string password)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                var foundUser = baseRepository.Read(u => u.UserName == userName && u.Password == password);
                return Tuple.Create<bool, User>(foundUser != null && foundUser.Count() > 0, foundUser?.FirstOrDefault() ?? null);
            }
            return Tuple.Create<bool, User>(false, null);
        }
    }
}
