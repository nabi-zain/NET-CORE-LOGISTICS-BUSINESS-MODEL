using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerClaims")]
    public class CustomerClaims
    {
        [Key]
        public int CusomterClaimUD { get; set; }
        public int CustomerID { get; set; }
        public string CustomerCode { get; set; }
        public string ClaimType { get; set; }
        public int ClaimNo { get; set; }

        public string WaybillNo { get; set; }
        public long WaybillID { get; set; }
        public DateTime WaybillDate { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public decimal AmountClaimed { get; set; }
        public decimal AmountRefunded { get; set; }
        public string Status { get; set; }
        public DateTime MonthInserted { get; set; }

    }
}
