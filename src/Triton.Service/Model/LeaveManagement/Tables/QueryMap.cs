using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("QueryMap")]
    public class QueryMap
    {
        [Key]
        public int ID { get; set; }
        public string MapName { get; set; }
        public string ExcelColumn { get; set; }
        public string DbTableColumn { get; set; }
    }
}
