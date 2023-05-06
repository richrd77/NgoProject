using Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface ILoginService : IBaseService<User>
    {
        /// <summary>
        /// True if credentials match, False if it doesn't match
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Tuple<bool, User> Login(string userName, string password);
    }
}
