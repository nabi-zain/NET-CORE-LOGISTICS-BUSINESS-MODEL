using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("WayBillStatuss")]
    public class WayBillStatuss
    {
        [Key]
        public int WayBillStatusID { get; set; }
        public string WaybillStatus { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
    }
}
