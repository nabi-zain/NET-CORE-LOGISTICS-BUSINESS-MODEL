using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("LostCustomers")]
    public class LostCustomers
    {
        public int LostCustomerID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DateInitiated { get; set; }
        public long InitiatedByID { get; set; }
        public int? LostBusinessFailureID { get; set; }
        public string LostReason { get; set; }
        public int? OpTransporter1 { get; set; }
        public int? OpTransporter2 { get; set; }
        public int? OpTransporter3 { get; set; }
        public long? UpdatedByID { get; set; }
        public int? LastStageID { get; set; }
        public string Outcome { get; set; }
        public int? LostRevenueperMonth { get; set; }
        public DateTime? DateLost { get; set; }
        public decimal? ValueforRegain { get; set; }
        public string RegainComment { get; set; }
        public string Action { get; set; }
        public int? AllocatedRepCodeID { get; set; }
        public string AllocatedRepComment { get; set; }
        public int? AllocatedBranchID { get; set; }
    }
}
