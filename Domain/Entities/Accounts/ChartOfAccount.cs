using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ChartOfAccount
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }      
        public ChartOfAccount Account { get; set; }         
    }
}
