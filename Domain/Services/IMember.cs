using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Entity;

namespace Domain.Services
{
    public interface IMemberService : IBaseService<Member>
    {
        Dictionary<string, string> TypeOfUser { get; }
        bool Member(Member member);
        new List<Member> GetAll();
    }
}
