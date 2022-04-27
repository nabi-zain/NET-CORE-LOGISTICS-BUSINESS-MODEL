using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.CRM.Tables
{
    [Table("DeliveryManifestLineItems")]
    public class DeliveryManifestLineItems 
    {

        [Key]
        public  Int64 DeliveryManifestLineItemID { get; set; }
        public  Int64 DeliveryManifestID { get; set; }
        [DisplayName("Line")]
        public  Int32 LineNumber { get; set; }
        [DisplayName("Status")]
        public  Int32 DelManifestlineItemStatusID { get; set; }
        [DisplayName("Waybill")]
        public  Int64 WaybillID { get; set; }
        [DisplayName("Customer")]
        public  Int32 CustomerID { get; set; }
        [DisplayName("Service")]
        public  Int32 ServiceTypeID { get; set; }
        [DisplayName("Qty")]
        public  Int32 ItemQty { get; set; }
        [DisplayName("QtyDel")]
        public  Int32 ItemQtyDel { get; set; }
        [DisplayName("Vol")]
        public  Decimal ItemVol { get; set; }
        [DisplayName("Value")]
        public  Decimal ItemValue { get; set; }
        [DisplayName("Mass")]
        public  Decimal ItemMass { get; set; }
        [DisplayName("RecSite")]
        public  String ReceiverSite { get; set; }
        [DisplayName("RecName")]
        public  String ReceiverName { get; set; }
        [DisplayName("Add1")]
        public  String RecAdd1 { get; set; }
        [DisplayName("Add2")]
        public  String RecAdd2 { get; set; }
        [DisplayName("Add3")]
        public  String RecAdd3 { get; set; }
        [DisplayName("Add4")]
        public  String RecAdd4 { get; set; }
        [DisplayName("PostalCode")]
        public  String RecAddPostalCode { get; set; }
        [DisplayName("Contact")]
        public  String RecContact { get; set; }
        [DisplayName("Tel No")]
        public  String RecTelNo { get; set; }
        [DisplayName("Returned")]
        public  String RetReasons { get; set; }
        [DisplayName("Instructions")]
        public  String RecInstructions1 { get; set; }
        [DisplayName("Instructions 2")]
        public  String RecInstructions2 { get; set; }
        [DisplayName("Remarks")]
        public  String Remarks { get; set; }
        public  DateTime? TimeDelivered { get; set; }

    }
}

