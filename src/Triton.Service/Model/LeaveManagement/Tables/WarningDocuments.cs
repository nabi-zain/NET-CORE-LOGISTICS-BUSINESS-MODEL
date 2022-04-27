using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("WarningDocuments")]
    public class WarningDocuments
    {
        [Key]
        public int ID { get; set; }
        public int? SystemID { get; set; }
        public int? RecordID { get; set; }
        public int? EmployeeID { get; set; }
        public  int? BlobID { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreatedByEmployeeID { get; set; }
    }
}
