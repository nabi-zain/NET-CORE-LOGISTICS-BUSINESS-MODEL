using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    public class CustomerLogs
    {
        [Key]
        public int CustomerLogsID { get; set; }
        public string Status { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ChangedBy { get; set; }
        public string ChangedBySystem { get; set; }
        public byte Processed { get; set; }
        public byte Changed { get; set; }
        public int CustomerID { get; set; }
        public string AccountCode { get; set; }
        public int BranchID { get; set; }
        public string Name { get; set; }
        public byte LinkedAccounted { get; set; }
        public int LinkedCustomerID { get; set; }
        public byte FWSystemAccount { get; set; }
        public byte InternalAccount { get; set; }
        public DateTime LastIncreaseDate { get; set; }
        public DateTime NextIncreaseDate { get; set; }
        public string Contact { get; set; }
        public string TellNo { get; set; }
        public string FaxNo { get; set; }
        public string CellNo { get; set; }
        public string AddLine1 { get; set; }
        public string AddLine2 { get; set; }
        public string AddLine3 { get; set; }
        public string AddLine4 { get; set; }
        public string PostalCode { get; set; }
        public byte MarkForClosure { get; set; }
        public int StatusID { get; set; }
        public int CustomerAccountTypeID { get; set; }
        public string FWRateAccCode { get; set; }
        public string FWrepCode { get; set; }
        public byte HasUniques { get; set; }
        public decimal Insurance { get; set; }
        public int VolRatio { get; set; }
        public string Swat { get; set; }
        public decimal Avg { get; set; }
        public decimal Compliance { get; set; }

        public int RateClassID { get; set; }
        public DateTime AccountCreatedDate { get; set; }
    }
}
