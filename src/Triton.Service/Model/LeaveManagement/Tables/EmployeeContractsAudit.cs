using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("EmployeeContractsAudit")]
    public class EmployeeContractsAudit
    {
        [Key]
        public int ContractAuditID { get; set; }
        public string FieldName { get; set; }
        public string PreviousValue { get; set; }
        public string UpdatedValue { get; set; }
        public int UpdatedByUserId { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
