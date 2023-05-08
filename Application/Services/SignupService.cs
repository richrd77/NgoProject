using Application.Common.Enum;
using Domain.Models.Entity;
using Domain.Models.ViewModels;
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
        private readonly IBaseRepository<User> baseRepository;

        public SignupService(IBaseRepository<User> baseRepository) : base(baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public Dictionary<string, string> Roles => new Dictionary<string, string>
        {
            { "-1", "----Select Role----" },
            { ((int)RoleEnum.Member).ToString(), RoleEnum.Member.ToString() },
            { ((int)RoleEnum.Volunteer).ToString(), RoleEnum.Volunteer.ToString() },
            { ((int)RoleEnum.Administrator).ToString(), RoleEnum.Administrator.ToString() },
            { ((int)RoleEnum.FundRaiser).ToString(), RoleEnum.FundRaiser.ToString() },
            { ((int)RoleEnum.Donar).ToString(), RoleEnum.Donar.ToString() }
        };

        public Dictionary<string, string> Genders => new Dictionary<string, string> { { "-1", "----Select Gender----" }, { "M", "Male" }, { "F", "Female" } };

        public Tuple<bool, User> Signup(SignupViewModel vm)
        {
            if (DateTime.TryParse(vm.BirthDate, out DateTime dob))
            {

                baseRepository.Create(new User
                {
                    Address = vm.Address,
                    BirthDate = dob,
                    Email = vm.Email,
                    UserName = vm.Email,
                    Mobile = vm.Mobile,
                    Name = vm.Name,
                    Password = vm.Password,
                    Gender = char.Parse(vm.Gender),
                    RoleId = int.Parse(vm.Role)
                });
                baseRepository.Save();
            }
            return Tuple.Create<bool, User>(false, null);
        }
    }
}
