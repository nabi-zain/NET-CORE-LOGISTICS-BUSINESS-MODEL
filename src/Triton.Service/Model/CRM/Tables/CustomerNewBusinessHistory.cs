using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerNewBusinessHistory")]
    public class CustomerNewBusinessHistory
    {
        public int CustomerNewBusinessHistoryID { get; set; }
        public int CustomerID { get; set; }
        public int FinancialYear { get; set; }
        public int TargetQuater { get; set; }
        public DateTime RevisedAnniversary { get; set; }
        public int newBusinessCeiling { get; set; }
        public string Comment { get; set; }
        public byte BankCarry { get; set; }
        public byte ActiveNewBusiness { get; set; }
        public byte isError { get; set; }
        public string ErrorReason { get; set; }
        public DateTime DateUploaded { get; set; }
        public int Userid { get; set; }
        public byte AccumlatedBillingOnly { get; set; }
        public byte CommisionCorrection { get; set; }
        public DateTime FirstRegrade { get; set; }
        public DateTime finalRegrade { get; set; }
    }
}
