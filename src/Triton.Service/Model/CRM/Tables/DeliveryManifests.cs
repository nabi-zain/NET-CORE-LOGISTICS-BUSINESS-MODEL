using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.CRM.Tables
{
    [Table("DeliveryManifests")]
    public class DeliveryManifests
    {
        [Dapper.Contrib.Extensions.Key]
        public  Int64 DeliveryManifestID { get; set; }
        [DisplayName("Manifest")]
        public  String DelManifestNumber { get; set; }

        [DisplayName("Date")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public  DateTime? DelManifestDate { get; set; }
        public  Int32 BranchID { get; set; }
        public  Int32 RouteID { get; set; }

        public  String ZoneController { get; set; }
        [DisplayName("Subcontractor")]
        public  Int32 SubContractorID { get; set; }
        [DisplayName("Sub Doc No")]
        public  String SubContractorDocNo { get; set; }
        [DisplayName("Status")]
        public  Int32 DelManStatusID { get; set; }
        public  String FWIDCapture { get; set; }
        public  String FWIDModify { get; set; }
        public  Int32 TotalQty { get; set; }
        public  Decimal TotalMass { get; set; }
        public  Decimal TotalValue { get; set; }
        public  Decimal TotalVolume { get; set; }
        public  String FWDriver { get; set; }
        public  String FWVehicleReg { get; set; }
        public  Int32 VehicleID { get; set; }
        public  Int32? TrailerVehicleID { get; set; }
    }
}

