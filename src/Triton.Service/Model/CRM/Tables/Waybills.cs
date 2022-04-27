using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.CRM.Tables
{
    [Table("Waybills")]
    public class Waybills
    {
        [Dapper.Contrib.Extensions.Key]
        public long WaybillID { get; set; }
        public int? CustomerID { get; set; }

        [DisplayName("Waybill No")]
        [Required]
        public string WaybillNo { get; set; }

        [DisplayName("Waybill Date")]
        [Required]
        public DateTime? WaybillDate { get; set; }

        public int? SendCustomerSiteMapID { get; set; }
        public int? ReceiveCustomerSiteMapID { get; set; }
        public string ManifestID { get; set; }
        public int? CollectionID { get; set; }
        public int? DeliveryID { get; set; }
        public int? InvoiceID { get; set; }
        public int? RepID { get; set; }
        public int? WaybillStatusID { get; set; }
        public int? FinancialStatusID { get; set; }
        public int? LoadTypeID { get; set; }
        public int? ServiceTypeID { get; set; }
        public int? FromBranchID { get; set; }
        public int? ToBranchID { get; set; }
        public string SubContractorDocNo { get; set; }
        public decimal? CustomerInvoiceValue { get; set; }
        public int? TotalQty { get; set; }
        public decimal? TotalMass { get; set; }
        public decimal? TotalVolume { get; set; }
        public decimal? ChargeMass { get; set; }
        public decimal? FreightValue { get; set; }
        public decimal? FuelSurcharge { get; set; }
        public decimal? DocumentationFee { get; set; }
        public decimal? ChargesSubTotal { get; set; }
        public decimal? Vat { get; set; }
        public decimal? TotalValue { get; set; }
        public int? LineHaulCostID { get; set; }
        public decimal? Insurance { get; set; }
        public decimal? Compare1OrigValue { get; set; }
        public decimal? Compare1NewValue { get; set; }
        public decimal? Compare1NewChrgMass { get; set; }
        public decimal? Compare1VariancePerc { get; set; }
        public decimal? Compare2OrigValue { get; set; }
        public decimal? Compare2NewValue { get; set; }
        public decimal? Compare2NewChrgMass { get; set; }
        public decimal? Compare2VariancePerc { get; set; }
        public bool? PassServiceCompliance { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public DateTime? PODDateTimeStamp { get; set; }
        public string PODFWDateString { get; set; }
        public string PODFWTimeString { get; set; }
        public string FailServiceComplianceReason { get; set; }
        public int? FailServiceComplianceReasonCodeID { get; set; }
        public int? FailServiceComplianceReasonGroupID { get; set; }
        public string BookingFWDateString { get; set; }
        public string BookingFWTimeString { get; set; }
        public DateTime? BookingDateTime { get; set; }
        public int? CollSubContractorID { get; set; }
        public int? DelSubContractorID { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public string CustomerXRef { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public string CustomerXRef2 { get; set; }
        public bool ReportExclude { get; set; }
        public bool SwatExclusion { get; set; }
        public string SwatExclusionReason { get; set; }
        public int? FromRateAreaID { get; set; }
        public int? ToRateAreaID { get; set; }
        public int? TempRateAreaID { get; set; }
        public string IDModify { get; set; }
        public string IDCapture { get; set; }
        public string FWDelExpDateString { get; set; }
        public string FWDelExpTimeString { get; set; }
        public DateTime? DelExpectedDateTimeStamp { get; set; }
        public bool? DelExpectedFailed { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string FWCurrentBranch { get; set; }
        public int? CurrentBranchID { get; set; }
        public long? CollectionRequestID { get; set; }
        public int? CollectionManifestLineNo { get; set; }
        public bool? ChainStoreDelivery { get; set; }
        public string PODEndorsement { get; set; }
        public decimal? TritonVolume { get; set; }
        public decimal? TritonChargeMass { get; set; }
        public String PODRecvBy { get; set; }
    }
}
