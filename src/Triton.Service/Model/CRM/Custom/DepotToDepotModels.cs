using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using  Triton.Model.CRM.StoredProcs;
using  Triton.Model.CRM.Tables;
using  Triton.Model.TritonSecurity.Tables;

namespace  Triton.Model.CRM.Custom
{
    public class DepotToDepotModels
    {
        public DTDRequests DTDRequest { get; set; }
        public List<DTDRequestLines> DTDRequestLines { get; set; }
        public List<Branches> Branches { get; set; }
        
        public  Triton.Model.TritonGroup.Tables.LookUpCodes DTDStatus { get; set; }

        public Branches FromBranch
        {
            get
            {
                if (DTDRequest != null && Branches != null && Branches.Count > 0)
                {
                    return Branches.Find(x => x.BranchID == DTDRequest.FromBranchID);
                }
                else return null;
            }
        }

        public Branches ToBranch
        {
            get
            {
                if (DTDRequest != null && Branches != null && Branches.Count > 0)
                {
                    return Branches.Find(x => x.BranchID == DTDRequest.ToBranchID);
                }
                else return null;
            }
        }

        public string FromBranchNameString { get { return FromBranch != null ? "Triton Express " + FromBranch.FWDepotCode : null; } }
        public string ToBranchNameString { get { return ToBranch != null ? "Triton Express " + ToBranch.FWDepotCode : null; } }
        public List<DTDRequestExtras> Extras { get; set; }
        public string DTDRequestLinesJSON { get; set; }
        public string DTDRequestExtrasJSON { get; set; }
        [DisplayName("Total Charge")]
        public decimal TotalCharge {
            get {
                if (DTDRequestLines==null || DTDRequestLines.Count==0)
                    return 75M;
                else {

                    return DTDRequestLines.Sum(m => m.Charge) * 1.15M;
                }
            } }
        [DisplayName("Vat")]
        public decimal TotalVAT
        {
            get {
                if (DTDRequestLines == null || DTDRequestLines.Count == 0)
                    return 9.78M;
                else
                {
                    return (DTDRequestLines.Sum(m => m.Charge) * 1.15M) - DTDRequestLines.Sum(m => m.Charge);
                }
            }
        }
        [DisplayName("Freight Charge")]
        public decimal UnitCharge
        {
            get { return 65.22M; }
        }

        public string BillingFirstName { get; set; }
        public string BillingLastName { get; set; }
        public string BillingEmail { get; set; }

        public int? OverMass { get; set; }
        public Decimal RatePerKG { get { return 2.61M; } }

        public bool hasConfirmedWaybill { get; set; }
    }

    public class DepotToDepotCookie
    {
        public DTDRequests DTDRequest { get; set; }
        public List<DTDRequestLines> DTDRequestLines { get; set; }
    }

    public class DepotToDepotSearchModel
    {
        [DisplayName("From")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? FromDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [DisplayName("To")]
        public DateTime? ToDate { get; set; }
        [DisplayName("Status")]
        public int? DTDStatusLCID { get; set; }
        [DisplayName("WaybillNo")]
        public String DTDRef { get; set; }
        public List<proc_DepotToDepotSearch> DTDTransactions { get; set; }
        public List< Triton.Model.TritonGroup.Tables.LookUpCodes> StatusCodes { get; set; }
        [DisplayName("Ignore Dates")]
        public bool IgnoreDates { get; set; }

    }
}