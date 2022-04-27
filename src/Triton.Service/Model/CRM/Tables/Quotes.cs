using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.CRM.Tables
{
    [Table("Quotes")]
    public class Quotes
    {
        [Dapper.Contrib.Extensions.Key]
        public int QuoteID { get; set; }
        public String QuoteNo { get; set; }
        [Display(Name = "Customer")]
        public int CustomerID { get; set; }
        [Display(Name="Contact")]
        public string ContactName { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string CustCode { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name="Date Quoted")]
        public DateTime DateQuote { get; set; }
        public int? RecSiteID { get; set; }
        [Display(Name="Site Code")]
        public string RecSite { get; set; }
        [Display(Name="Site Name")]
        public string RecName { get; set; }
        [Display(Name="Address1")]
        public string RecAdd1 { get; set; }
        [Display(Name="Address2")]
        public string RecAdd2 { get; set; }
        [Display(Name="Address3")]
        public string RecAdd3 { get; set; }
        [Display(Name="Suburb")]
        public string RecAdd4 { get; set; }
        [Display(Name="Postal Code")]
        public string RecAdd5 { get; set; }
        [Display(Name="Contact")]
        public string RecContact { get; set; }
        [Display(Name="Fax No")]
        public string RecFaxNo { get; set; }
        [Display(Name="Tel. No")]
        public string RecTelNo { get; set; }
        [Display(Name="Instructions")]
        public string RecInstructions1 { get; set; }
        public string RecInstructions2 { get; set; }
        public int? SenSiteID { get; set; }
        [Display(Name="Site Code")]
        public string SenSite { get; set; }
        [Display(Name="Site Name")]
        public string SenName { get; set; }
        [Display(Name="Address1")]
        public string SenAdd1 { get; set; }
        [Display(Name="Address2")]
        public string SenAdd2 { get; set; }
        [Display(Name="Address3")]
        public string SenAdd3 { get; set; }
        [Display(Name="Suburb")]
        public string SenAdd4 { get; set; }
        [Display(Name="Postal Code")]
        public string SenAdd5 { get; set; }
        [Display(Name="Contact")]
        public string SenContact { get; set; }
        [Display(Name="Fax No")]
        public string SenFaxNo { get; set; }
        [Display(Name="Tel. No")]
        public string SenTelNo { get; set; }
        [Display(Name="Instructions")]
        public string SenInstructions1 { get; set; }
        public string SenInstructions2 { get; set; }
        public int ServiceTypeID { get; set; }
        [Display(Name="Service Level")]
        public string ServiceTypeText { get; set; }
        public string SignatureReturned  { get; set; }
        public string SigneeName { get; set; }
        [Display(Name="Insurance")]
        public string InsuranceValue { get; set; }
        [Display(Name="Declared Value")]
        public string ValDeclared { get; set; }
        [Display(Name="Discount Rate")]
        public string DiscountRate { get; set; }
        public string Remarks { get; set; }
        [Display(Name="Cross Referance")]
        public string XrefNo { get; set; }
        public String AreaFrom { get; set; }
        public String AreaFromName { get; set; }
        public String AreaTo { get; set; }
        public String AreaToName { get; set; }
        public string Branch { get; set; }
        public String BranchName { get; set; }
        public int? BranchID { get; set; }
        [Display(Name="Discount")]
        public Decimal? DiscountVal { get; set; }
        [Display(Name="Freight Charge")]
        public Decimal? FreightValue { get; set; }
        public string IdCapture { get; set; }
        public string IdModify { get; set; }
        public Decimal? InsurancePercentage { get; set; }
        public string OrderNo { get; set; }
        public string QuoteAccepted { get; set; }
        public Decimal? QuoteExpiryDate { get; set; }
        [Display(Name="Quote Expires")]
        public DateTime? QuoteExpiryDateStamp { get; set; }
        public Decimal? DateReturned { get; set; }

        public Decimal? TimeReturned { get; set; }
        public DateTime? ReturnedDateTimeStamp { get; set; }
        public decimal StatusInd { get; set; }
        public string StatusName { get; set; }
        public Decimal TotalMass { get; set; }
        public Decimal TotalQty { get; set; }
        public Decimal TotalValue { get; set; }
        public Decimal TotalVolume { get; set; }
        public Decimal ValueDeclared { get; set; }
        public Decimal Vat { get; set; }
        public string WaybillNo { get; set; }
        public Int64 WaybillID { get; set; }
        public decimal QuoteLineCtr { get; set; }
        public int? CreatedByTSUserID { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
