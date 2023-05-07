using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entity
{
    public class Money : BaseEntity
    {
        public string Name { get; set; }

        public double Amount { get; set; }

        public DateTime? Date { get; set; }

        public int TransactionTypeId { get; set; }

        public virtual Transaction TransactionType { get; set; }
    }
}
