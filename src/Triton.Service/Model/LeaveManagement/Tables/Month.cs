using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("Month")]
   public  class Month
    {
        [Key]
        public int ID { get; set; }
        public string MonthName { get; set; }
    }
}
