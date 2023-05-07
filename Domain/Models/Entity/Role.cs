using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entity
{
    public class Role : BaseEntity
    {
        public string Type { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
