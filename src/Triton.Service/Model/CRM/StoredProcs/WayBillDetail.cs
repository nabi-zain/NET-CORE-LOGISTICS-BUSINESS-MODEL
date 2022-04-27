using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.CRM.StoredProcs
{
    public class WayBillDetail
    {
        public string WaybillNo { get; set; }
        public DateTime waybillDate { get; set; }
        public string ID { get; set; }
        public decimal TotalQty { get; set; }
        public decimal TotalVolume { get; set; }
        public decimal TotalMass { get; set; }
        public decimal ChargeMass { get; set; }
        public decimal FreightValue { get; set; }
        public decimal ChargeSubTotal { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public DateTime AnniversaryDate { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string ManifestNo { get; set; }
        public string InvoiceNo { get; set; }
        public int WaybillID { get; set; }
        public string ServiceLevel { get; set; }
        public string PODDate { get; set; }
        public string PODTime { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoicePeriod { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Compare20rigValue { get; set; }
        public string LoadType { get; set; }
        public string SWAT { get; set; }
        public string Compare1SWAT { get; set; }
        public string NewAnniv { get; set; }
        public string Sender { get; set; }
        public string SenderPostalCode { get; set; }
        public string Receipient { get; set; }
        public DateTime EndDate { get; set; }
        public string SwatExclusion { get; set; }
        [Column( "PODDate Time")]
        public string PODDateTime { get; set; }
        public string FuelSurchange { get; set; }
        public string DocumentationFee { get; set; }
        public string VAT { get; set; }
        public decimal Insurance { get; set; }
        public decimal SwatTotal { get; set; }
        public string WorkingDays { get; set; }
        

    }
}
