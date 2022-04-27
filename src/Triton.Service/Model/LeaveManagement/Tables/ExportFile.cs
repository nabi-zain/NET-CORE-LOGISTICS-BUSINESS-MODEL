using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("ExportFile")]
    public class ExportFile
    {

        public int ID { get; set; }
        public int Total { get; set; }
        public DateTime CreateDate { get; set; }
        public string FileName { get; set; }
    }
}
