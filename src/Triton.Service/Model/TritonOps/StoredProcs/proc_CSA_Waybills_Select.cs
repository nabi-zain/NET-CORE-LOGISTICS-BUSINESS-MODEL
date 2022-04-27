using System;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_CSA_Waybills_Select
    {
        public long WaybillID { get; set; }
        public string WaybillNo { get; set; }
        public int CustomerID { get; set; }
        public DateTime WaybillDate { get; set; }
        public string Orig { get; set; }
        public string Dest { get; set; }
        public string Status { get; set; }
        public string Service { get; set; }
        public string CustomerXRef { get; set; }
        public string CustomerXRef2 { get; set; }
        public string Name { get; set; }
        public string Sender { get; set; }
        public string Recepient { get; set; }
        public string SuburbFrom { get; set; }
        public string SurburbTo { get; set; }
        public string PODFWDateString { get; set; }
        public string PODFWTimeString { get; set; }
        public string PODDateTimeStamp { get; set; }
        public string TotalQty { get; set; }
        public string TotalMass { get; set; }
        public string TotalVolume { get; set; }
        public string ChargeMass { get; set; }
        public string FreightValue { get; set; }
        public string FuelSurcharge { get; set; }
        public string DocumentationFee { get; set; }
        public string ChargesSubTotal { get; set; }
        public string Vat { get; set; }
        public string TotalValue { get; set; }
        public string DeliverySheetDate { get; set; }
        public string DeliveryRoute { get; set; }
        public string ZoneController { get; set; }
        public DateTime DelExpectedDateTimeStamp { get; set; }
        public string FWCurrentBranch { get; set; }
    }
}
