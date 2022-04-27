using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class CustomerAuditModel
    {
        public Int64 CustomerAuditID { get; set; }
        public string Type { get; set; }
        public string PKColumnName { get; set; }
        public Int64 PK { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public string CreatedBy { get; set; }
    }
}
