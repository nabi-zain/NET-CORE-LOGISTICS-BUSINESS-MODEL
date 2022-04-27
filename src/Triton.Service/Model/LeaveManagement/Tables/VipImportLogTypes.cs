using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("VipImportLogTypes")]
    public class VipImportLogTypes
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
