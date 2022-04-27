using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CollectionManifestLineItems")]
    public class CollectionManifestLineItems
    {
        public long CollectionManifestLineItemID { get; set; }
        public long CollectionManifestID { get; set; }
        public int LineNumber { get; set; }
        public int CollectionManifestLineItemStatusID { get; set; }
        public string TimeCollAfter { get; set; }
        public string TimeCollBefore { get; set; }
        public string TimeAllocToMan { get; set; }
        public string TimeCollConfirm { get; set; }
        public string TimeCollected { get; set; }
        public int CustomerID { get; set; }
        public string RetReasons { get; set; }
        public int ReturnReasonID { get; set; }
        public string OrderNumber { get; set; }
        public int ServiceTypeID { get; set; }
        public int ItemQty { get; set; }
        public decimal ItemMass { get; set; }
        public decimal ItemVol { get; set; }
        public string Remark { get; set; }
        public string SenderSite { get; set; }
        public string  SenderName { get; set; }
        public string SenAdd1 { get; set; }
        public string SenAdd2 { get; set; }
        public string senAdd3 { get; set; }
        public string SenAdd4 { get; set; }
        public string SenAddPostalCode { get; set; }
        public string SenContact { get; set; }
        public string SenTelNo { get; set; }
        public string ReceiverName { get; set; }
        public string RecAdd1 { get; set; }
        public string RecAdd2 { get; set; }
        public string RecAdd3 { get; set; }
        public string RecAdd4 { get; set; }
        public string RecAddPostalCode { get; set; }
        public string RecContact { get; set; }
        public string RecTelNo { get; set; }
        public string SenderInstructions1 { get; set; }
        public string SenderInstructions2 { get; set; }
        public long CollectionRequestID { get; set; }
    }
}
