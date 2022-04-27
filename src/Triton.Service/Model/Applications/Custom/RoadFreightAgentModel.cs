using System;

namespace Triton.Service.Model.Applications.Custom
{
    public class RoadFreightAgentModel
    {
        public int RoadFreightAgentID { get; set; }
        public string SupplierDate { get; set; }
        public string SubCode { get; set; }
        public string WaybillNo { get; set; }
        public string Consolidated { get; set; }
        public decimal? Volumetric { get; set; }
        public decimal? Mass { get; set; }
        public decimal? Surcharge { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public string Invoice { get; set; }
        public int StatusLCID { get; set; }
        public int SupplierID { get; set; }
        public int? WaybillID { get; set; }
        public decimal? FWChargeExVat { get; set; }
        public decimal? FWChargeUnits { get; set; }
        public int CategoryLCID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public int? DeletedOn { get; set; }
        public string Comments { get; set; }
        public string IssueType { get; set; }
        public string FromRateArea { get; set; }
        public string ToRateArea { get; set; }
        public decimal ? TotalValue { get; set; }
        public decimal ? ChargesSubTotal { get; set; }
        public int? ReasonLCID { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public string FAIconString { get; set; }
        public string AdditionalField1Name { get; set; }
        public string AdditionalField1Value { get; set; }

        public bool IsChecked { get; set; }
    }
}
