using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("Leads")]
    public class Leads
    {
        [Key]
        public long LeadID { get; set; }
        public long RefEnquiryID { get; set; }
        public string CompanyName { get; set; }
        public int? BranchID { get; set; }
        public string Location { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string Industry { get; set; }
        public string Remarks { get; set; }
        public string LeadRef { get; set; }
        public string CompanyEmail { get; set; }
        public decimal? EstExp { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int? PostalCode { get; set; }
        public string AccountNumber { get; set; }
        public bool HasManualRates { get; set; }
        public int? IndustryID { get; set; }
        public string ManualNote { get; set; }
        public bool HasSpecialVolume { get; set; }
        public int? SpecialVolumeID { get; set; }
        public string SpecVolumeReason { get; set; }
        public bool IsDepottoDepot { get; set; }
        public bool MarkforSd { get; set; }
        public int? VerticalMarketID { get; set; }
        public int? SubVerticalMarketID { get; set; }
        public decimal? SpecialFuelPerc { get; set; }
        public decimal? SpecialFuelPercMin { get; set; }
        public string SpecFuelReason { get; set; }
        public bool HasSpecialFuel { get; set; }
        public bool HasSpecialDocFee { get; set; }
        public decimal? SpecialDocFeeFigure { get; set; }
        public bool CrossBorderOnly { get; set; }
        public int SaleTypeID { get; set; }
        public int? CustomerGroupID { get; set; }
        public bool IsNew { get; set; }
        public string CompanyDivision { get; set; }
        public int? CountryID { get; set; }
        public int? CompanyID { get; set; }
        public decimal? SpendT1 { get; set; }
        public decimal? SpendT2 { get; set; }
        public decimal? SpendT4 { get; set; }
        public decimal? SpendT5 { get; set; }
        public decimal? SpendXBorder { get; set; }
        public decimal? SpendWarehousing { get; set; }
        public decimal? SpendPtl { get; set; }
        public decimal? SpendFtl { get; set; }
        public decimal? SpendIntAir { get; set; }
        public decimal? SpendIntRoad { get; set; }
        public decimal? SpendIntSea { get; set; }
        public decimal? SpendIntRail { get; set; }
        public int? ExpStartingFinancialMonth { get; set; }
        public string OppurtunitySupporter { get; set; }
        public bool IsCapexReq { get; set; }
        public decimal? CapexAmount { get; set; }
        public DateTime? SubmissionDueBy { get; set; }
        public int FuelSurchargeClassID { get; set; }
    }
}
