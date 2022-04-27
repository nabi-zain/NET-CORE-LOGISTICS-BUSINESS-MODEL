using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Triton.Model.CRM.Tables;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_WaybillTrackAndTraceCustomer
    {
        public long WaybillID { get; set; }
        public string WaybillNo { get; set; }
        public int CustomerID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? WaybillDate { get; set; }
        public string Orig { get; set; }
        public string Dest { get; set; }
        public string waybillStatus { get; set; }
        public string Service { get; set; }
        public string CustomerXRef { get; set; }
        public string CustomerXRef2 { get; set; }
        public string Name { get; set; }
        public string Sender { get; set; }
        public string Receipient { get; set; }
        public string SuburbFrom { get; set; }
        public string SuburbTo { get; set; }
        public string PODFWDateString { get; set; }
        public DateTime? PODDateTimeStamp { get; set; }
        public int? TotalQty { get; set; }
        public decimal? TotalMass { get; set; }
        public decimal? TotalVolume { get; set; }
        public decimal? ChargeMass { get; set; }
        public decimal? FreightValue { get; set; }
        public decimal? FuelSurcharge { get; set; }
        public decimal? DocumentationFee { get; set; }
        public decimal? ChargesSubTotal { get; set; }
        public decimal? Vat { get; set; }
        //public DateTime WaybillDate { get; set; }
        public decimal? TotalValue { get; set; }
        public string DeliverySheetDate { get; set; }
        public string DeliveryRoute { get; set; }
        public string ZoneController { get; set; }
        public DateTime DelExpectedDateTimeStamp { get; set; }
        public string FWCurrentBranch { get; set; }
        public int DeliveryID { get; set; }
        public string CustomerName { get; set; }
        public string AccountCode { get; set; }
        public string ReceiverSiteName { get; set; }
        
        public int WayBillStatusID { get; set; }
        public string SenderSiteCustomerName { get; set; }
        public string SenderAddress1 { get; set; }
        public string SenderAddress2 { get; set; }
        public string SenderAddress3 { get; set; }
        public string SenderPostalCode { get; set; }
        public string RecSiteCustomerName { get; set; }
        public string RecAddress1 { get; set; }
        public string RecAddress2 { get; set; }
        public string RecAddress3 { get; set; }
        public string RecPostalCode { get; set; }
        //public string ShortDesc { get; set; }
        //public string FWEventLocation { get; set; }
        //public string FWEventDate { get; set; } 
        //public string FWEventTime { get; set; }
        //public DateTime DeliveryDate { get; set; }
        //public DateTime LastUpDated { get; set; }
        //public string CustomerName { get; set; }
        //public  WaybillTrackandTraces WaybillTrackandTraces { get; set; }
        //public FWEventCodes FwEventCodes { get; set; }
    }
}