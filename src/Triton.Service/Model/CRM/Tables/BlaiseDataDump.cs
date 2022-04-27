using System;

using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace Triton.Model.CRM.Tables
{
    [Table("BlaiseDataDump")]
    public class BlaiseDataDump
    {
        public string CustCode { get; set; }
        public string CustName { get; set; }
        public string WayBillNo { get; set; }
        public DateTime WayBillDate { get; set; }
        public string SendSite { get; set; }
        public string Sender { get; set; }
        public string RecSite { get; set; }
        public string Recipent { get; set; }
        public string ManifestNo { get; set; }
        public string ManifesrSubcontractorNo { get; set; }
        public string CollectionSheetNo { get; set; }
        public string DeliverySheetNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string RepCode { get; set; }
        public string RepName { get; set; }
        public string WaybillStatus { get; set; }
        public string FinanceStatus { get; set; }
        public string Orig { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
        public string Dest { get; set; }
        public string DestSuburb { get; set; }
        public string DestPostalCode { get; set; }
        public string ServiceLevel { get; set; }
        public string FromBranch { get; set; }
        public string ToBranch { get; set; }
        public string SubContractorDocNo { get; set; }
        public string CollSubcontrator { get; set; }
        public string CollSubcontName { get; set; }
        public DateTime CollSheetDate { get; set; }
        public string CollRoute { get; set; }
        public string CollVehicle { get; set; }
        public string DelSubcontractor { get; set; }
        public string DelSubcontName { get; set; }
        public string DelSheetDate { get; set; }
        public string DelRoute { get; set; }
        public string DelVehicle { get; set; }
        public string ServComplRea { get; set; }
        public string PODDate { get; set; }
        public string PODTime { get; set; }
        public string BookingDate { get; set; }
        public string BookingTime { get; set; }
        public string LoadType { get; set; }
        public int CustomerVolumeRatio { get; set; }
        public int Qty { get; set; }
        public decimal ActualMass { get; set; }
        public decimal ActualVol { get; set; }
        public decimal ChrgMass { get; set; }
        public decimal FreightCharge { get; set; }
        public decimal FuelSchg { get; set; }
        public decimal Insur { get; set; }
        public decimal Docs { get; set; }
        public decimal SubTotal { get; set; }
        public decimal VAT { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotalExcFuel { get; set; }
        public decimal SwatCompareRate { get; set; }
        public decimal StartDate { get; set; }
        public decimal EndDate { get; set; }
        public long WayBillID { get; set; }
        public int CustomerID { get; set; }


    }
}
