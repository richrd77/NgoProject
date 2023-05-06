using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    class LoginService : ILoginService
    {
        public void Login(string userName, string password)
        {
            Console.WriteLine(userName, password);
        }
    }
}
