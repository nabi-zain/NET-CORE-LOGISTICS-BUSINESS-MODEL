using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.CRMSCS.Views
{
    public class vwOpsWaybills
    {
        public Int64 WaybillID { get; set; }

        public string WaybillNo { get; set; }

        public string CustomerName { get; set; }

        public string FromRateArea { get; set; }

        public string ToRateArea { get; set; }

        public string ServiceLevel { get; set; }

        public string ROUTE { get; set; }

        public string RouteName { get; set; }

        public string WaybillStatus { get; set; }

        public DateTime? WaybillDate { get; set; }

        public DateTime? DelExpectedDateTimeStamp { get; set; }

        public string Comment { get; set; }

        public DateTime? PODDateTimeStamp { get; set; }

        public string FWCurrentBranch { get; set; }

        public int? WaybillStatusID { get; set; }

        public int? CustomerID { get; set; }

        public bool? Depot { get; set; }

        public int? DeliveryID { get; set; }

        public int? ToBranchID { get; set; }

        public int? FromBranchID { get; set; }

        public string FinancialStatus { get; set; }

        public int TotalQty { get; set; }

        public decimal? TotalMass { get; set; }

        public decimal? TotalVolume { get; set; }

        public decimal? ChargeMass { get; set; }

        public decimal? FreightValue { get; set; }

        public decimal? FuelSurcharge { get; set; }

        public decimal? DocumentationFee { get; set; }

        public decimal? ChargesSubTotal { get; set; }

        public decimal? Vat { get; set; }

        public decimal? TotalValue { get; set; }

        public decimal? Insurance { get; set; }

        public string DeliveryNo { get; set; }

        public string ReceiverSiteCustomerName { get; set; }

        public string ReceiverAddress1 { get; set; }

        public string ReceiverAddress2 { get; set; }

        public string ReceiverAddress3 { get; set; }

        public string ReceiverAddress4 { get; set; }

        public string ReceiverPostalCode { get; set; }

        public string SenderSiteCustomerName { get; set; }

        public string SenderAddress1 { get; set; }

        public string SenderAddress2 { get; set; }

        public string SenderAddress3 { get; set; }

        public string SenderAddress4 { get; set; }

        public string SenderPostalCode { get; set; }
    }
}