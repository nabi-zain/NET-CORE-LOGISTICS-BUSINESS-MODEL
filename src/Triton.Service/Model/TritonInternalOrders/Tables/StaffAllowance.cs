using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonInternalOrders.Tables
{
    [Table("StaffAllowance")]
   public  class StaffAllowance
    {
        [Dapper.Contrib.Extensions.Key]
        public int AllowanceID { get; set; }
        public decimal Amount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
