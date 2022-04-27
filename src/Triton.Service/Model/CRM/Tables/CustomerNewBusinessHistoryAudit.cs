using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerNewBusinessHistoryAudit")]
    public class CustomerNewBusinessHistoryAudit
    {
        [Key]
        public long CustomerNewBusinessAuditID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DateStamp { get; set; }
        public int Year { get; set; }
        public int Week { get; set; }
        public int CustomerTradeStatusID { get; set; }
    }
}
