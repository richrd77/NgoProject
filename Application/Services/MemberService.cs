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
    class MemberService : BaseService<Member>, IMemberService
    {


        private readonly IBaseRepository<Member> baseRepository;

        public Dictionary<string, string> TypeOfUser => new Dictionary<string, string> { { "-1", "----Select Type----" }, { "1", "Children Education" }, { "2", "Social activities" }, { "3", "Other NGO activities" } };

        public MemberService(IBaseRepository<Member> baseRepository) : base(baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public bool Member(Member objMember)
        {
            this.baseRepository.Create(objMember);
            this.baseRepository.Save();

            return true;
        }

        public new List<Member> GetAll()
        {
            List<Member> MemberList = this.baseRepository.GetAll();

            return MemberList;
        }
    }
}
