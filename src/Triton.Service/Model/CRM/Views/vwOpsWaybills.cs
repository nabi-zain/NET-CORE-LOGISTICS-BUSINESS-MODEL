using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.CRM.Views
{
    // ReSharper disable once InconsistentNaming
    public class vwOpsWaybills
    {
        public long WaybillID { get; set; }

        [DisplayName("Waybill No")]
        public string WaybillNo { get; set; }

        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }

        [DisplayName("Waybill Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime? WaybillDate { get; set; }

        [DisplayName("Delivery Expected Date")]
        public DateTime? DelExpectedDateTimeStamp { get; set; }

        [DisplayName("POD Date")]
        public DateTime? PODDateTimeStamp { get; set; }

        [DisplayName("Rep Billing")]
        public decimal? Compare1OrigValue { get; set; }

        [DisplayName("Endorsement")]
        public string PODEndorsement { get; set; }

        [DisplayName("Last Updated")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime? LastUpdated { get; set; }

        [DisplayName("Financial Status")]
        public string FinancialStatus { get; set; }

        [DisplayName("Freight Value")]
        public decimal? FreightValue { get; set; }

        [DisplayName("Fuel Surcharge")]
        public decimal? FuelSurcharge { get; set; }

        [DisplayName("Documentation Fee")]
        public decimal? DocumentationFee { get; set; }

        [DisplayName("Charges Sub Total")]
        public decimal? ChargesSubTotal { get; set; }

        [DisplayName("VAT")]
        public decimal? Vat { get; set; }

        [DisplayName("Total Value")]
        public decimal? TotalValue { get; set; }

        [DisplayName("Insurance")]
        public decimal? Insurance { get; set; }

        [DisplayName("Load Type")]
        public string LoadType { get; set; }

        [DisplayName("Waybill Status")]
        public string WaybillStatus { get; set; }

        [DisplayName("Chargeable Mass")]
        public decimal? ChargeMass { get; set; }

        [DisplayName("Total Volume")]
        public decimal? TotalVolume { get; set; }

        [DisplayName("Triton Volume")]
        public decimal? TritonVolume { get; set; }

        [DisplayName("Triton Charge Mass")]
        public decimal? TritonChargeMass { get; set; }

        [DisplayName("Service Type")]
        public string ServiceType { get; set; }

        [DisplayName("Collection Sheet Number")]
        public string CollectionNo { get; set; }

        [DisplayName("Delivery Number")]
        public string DeliveryNo { get; set; }

        [DisplayName("Manifest Number")]
        public string ManifestNo { get; set; }

        [DisplayName("Sender Site")]
        public string Sender { get; set; }

        [DisplayName("Sender Name")]
        public string SiteName { get; set; }

        [DisplayName("Sender Address 1")]
        public string Address1 { get; set; }

        [DisplayName("Sender Address 2")]
        public string Address2 { get; set; }

        [DisplayName("Sender Address 3")]
        public string Address3 { get; set; }

        [DisplayName("Sender Address 4")]
        public string Address4 { get; set; }

        [DisplayName("Sender Postal Code")]
        public string PostalCode { get; set; }

        [DisplayName("Receiver Site")]
        public string ReceiverCustomerName { get; set; }

        [DisplayName("Receiver Name")]
        public string ReceiverSiteName { get; set; }

        [DisplayName("Receiver Address 1")]
        public string ReceiverAddress1 { get; set; }

        [DisplayName("Receiver Address 2")]
        public string ReceiverAddress2 { get; set; }

        [DisplayName("Receiver Address 3")]
        public string ReceiverAddress3 { get; set; }

        [DisplayName("Receiver Address 4")]
        public string ReceiverAddress4 { get; set; }

        [DisplayName("Receiver Postal Code")]
        public string ReceiverPostalCode { get; set; }

        [DisplayName("Collection Route")]
        public string CollectionRoute { get; set; }

        [DisplayName("Collection Vehicle")]
        public string CollectionVehicleRegistration { get; set; }

        [DisplayName("Delivery Route")]
        public string DeliveryRoute { get; set; }

        [DisplayName("Delivery Vehicle")]
        public string DeliveryVehicleRegistration { get; set; }

        [DisplayName("Delivery Bay")]
        public string DeliveryBay { get; set; }

        [DisplayName("Current Branch")]
        public string FWCurrentBranch { get; set; }

        [DisplayName("Chain Store")]
        public bool ChainStoreDelivery { get; set; }

        [DisplayName("Is Service Compliant?")]
        public bool PassServiceCompliance { get; set; }

        [DisplayName("Failure Reason (If applicable)")]
        public string FailServiceComplianceReason { get; set; }

        [DisplayName("Customer Billing")]
        public decimal? Compare2OrigValue { get; set; }

        [DisplayName("Swat Billing")]
        public decimal? Compare2NewValue { get; set; }

        [DisplayName("Swat Percentage")]
        public decimal? Compare2VariancePerc { get; set; }

        [DisplayName("Swat Exclusion Reason")]
        public string SwatExclusionReason { get; set; }

        [DisplayName("Account Code")]
        public string AccountCode { get; set; }

        [DisplayName("SL")]
        public string ServiceLevel { get; set; }

        [DisplayName("RT")]
        public string ROUTE { get; set; }

        [DisplayName("RT Name")]
        public string RouteName { get; set; }

        [DisplayName("Receiver")]
        public string SiteCustomerName { get; set; }

        public string Comment { get; set; }

        [ScaffoldColumn(false)]
        public int? WaybillStatusID { get; set; }

        [ScaffoldColumn(false)]
        public int? CustomerID { get; set; }

        [ScaffoldColumn(false)]
        public int? DeliveryID { get; set; }

        [ScaffoldColumn(false)]
        public int? ToBranchID { get; set; }

        [ScaffoldColumn(false)]
        public int? FromBranchID { get; set; }

        [DisplayName("To")]
        public string ToBranchFullName { get; set; }

        [DisplayName("From")]
        public string FromBranchFullName { get; set; }

        [DisplayName("Customer Name")]
        public string Name { get; set; }

        public bool? Depot { get; set; }

        [DisplayName("Exclude from SWAT")]
        public bool SwatExclusion { get; set; }

        [DisplayName("Late")]
        public string DaysLate { get; set; }

        public int? Agent { get; set; }

        [DisplayName("QTY")]
        public int TotalQty { get; set; }

        public decimal? TotalMass { get; set; }

        [DisplayName("RouteID")]
        public int RouteID { get; set; }

        [DisplayName("Comment Summary")]
        public string CommentSummary { get; set; }

        public int SiteID { get; set; }

        [DisplayName("CreatedBy")]
        public string Username { get; set; }

        public string ShortDesc { get; set; }
        public string CustomerXRef { get; set; }
    }

    public class vwOpsWaybillsModel
    {
        public List<vwOpsWaybills> OpsWaybills { get; set; }
        public vwOpsWaybills Waybills { get; set; }
    }
}
