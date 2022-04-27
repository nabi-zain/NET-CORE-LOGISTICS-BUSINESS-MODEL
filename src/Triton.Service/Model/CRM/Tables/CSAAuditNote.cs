using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.CRM.Tables
{
    [Table("CSAAuditNote")]
    public class CSAAuditNote
    {
        [Key]
        public int CSAAuditNoteID { get; set; }
        public int CustomerID { get; set; }
        public int CSALCID { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string Subject { get; set; }
        public DateTime WayBillDate { get; set; }
        public string EmailBody { get; set; }
        public byte [] Document { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime  CreatedOn { get; set; }
        public int ? DeletedByUserId { get; set; }
        public DateTime ? DeletedOn { get; set; }
    }
}
