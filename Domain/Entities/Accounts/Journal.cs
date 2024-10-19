using Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Journal
    {
        public int Id { get; set; }
        public int CoaId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public virtual ChartOfAccount Account { get; set; }
    }
}
