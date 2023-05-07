using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entity
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }

        public string Detail { get; set; }

        public DateTime Date { get; set; }
    }
}
