using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entity
{
    public class Transaction : BaseEntity
    {
        public string Type { get; set; }

        public virtual ICollection<Money> Transactions { get; set; }

    }
}
