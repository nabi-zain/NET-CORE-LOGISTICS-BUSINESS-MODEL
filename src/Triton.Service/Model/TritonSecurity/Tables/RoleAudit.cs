using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("RoleAudit")]
   public class RoleAudit
    {
        public int RoleAuditID { get; set; }
        public string User { get; set; }
        public string AuditType { get; set; }
        public string idMap { get; set; }
        public string Action { get; set; }
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string Detail3 { get; set; }
        public string Detail4 { get; set; }
        public string Detail5 { get; set; }
        public string Detail6 { get; set; }
        public string Detail7 { get; set; }
        public string Detail8 { get; set; }
        public string Detail9 { get; set; }
        public DateTime DateTimeGeneric { get; set; }
        public DateTime TimeDateStamp { get; set; }


    }
}
