using Domain.Models.Entity;
using Domain.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface ISignupService : IBaseService<User>
    {
        Dictionary<string, string> Roles { get; }
        
        Dictionary<string, string> Genders { get; }

        Tuple<bool, User> Signup(SignupViewModel vm);
    }
}
