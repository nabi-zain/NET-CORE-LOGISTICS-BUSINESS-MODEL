using Dapper.Contrib.Extensions;
using System;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace Triton.Model.CRM.Tables
{
    [Table("BranchCPKAudits")]
    public class BranchCPKAudits
    {
        [Key]
        public long BranchCPKAuditID { get; set; }
        public long BranchCPKID { get; set; }
        public int BranchID { get; set; }
        public DateTime ActiveMonth { get; set; }
        public decimal BranchCostsExcCDFuel { get; set; }
        public decimal BranchCDActual { get; set; }
        public decimal BranchMarkUp { get; set; }
        public int BranchLHRouteatTime { get; set; }
        public long ChangedByID { get; set; }
        public string Reason { get; set; }
        public DateTime ChangetimeStamp { get; set; }
    }
}
