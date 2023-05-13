using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entity
{
    public class Members : BaseEntity
    {
        public string Name { get; set; }

        public DateTime JoinDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
