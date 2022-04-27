using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DTDRequests")]
    public class DTDRequests
    {
       
        [Dapper.Contrib.Extensions.Key]
        public Int64 DTDrequestID { get; set; }
        [DisplayName("Requested")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime RequestDate { get; set; }
        public int CustomerID { get; set; }
        [DisplayName("From Depot")]
        public int FromBranchID { get; set; }
        [DisplayName("Sender")]
        public string FromContactName { get; set; }
        [DisplayName("Cell")]
        public string FromContactNumber { get; set; }
        [DisplayName("Email")]
        public string FromContactEmail { get; set; }
        [DisplayName("To Depot")]
        public int ToBranchID { get; set; }
        [DisplayName("Receiver")]
        public string ToContactName { get; set; }
        [DisplayName("Cell")]
        public string ToContactNumber { get; set; }
        [DisplayName("Email")]
        public string ToContactEmail { get; set; }
        [DisplayName("Notify via SMS")]
        public bool NotifyReceiverSMS { get; set; }
        [DisplayName("Notify via Email")]
        public bool NotifyReceiverEmail { get; set; }
        [DisplayName("Notify via SMS")]
        public bool NotifySenderSMS { get; set; }
        [DisplayName("Notify via Email")]
        public bool NotifySenderEmail { get; set; }
        [DisplayName("Requestor")]
        public string ContactName { get; set; }
        [DisplayName("Cell")]
        public string ContactNumber { get; set; }
        [DisplayName("Email")]
        public string ContactEmail { get; set; }
        [DisplayName("WaybillNo")]
        public Int64? WaybillID { get; set; }
        [DisplayName("Created By")]
        public int? CreatedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }", ApplyFormatInEditMode = true)]
        [DisplayName("Created On")]
        public DateTime? CreatedOn { get; set; }
        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }
        [DisplayName("Deleted On")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }", ApplyFormatInEditMode = true)]
        public DateTime? DeletedOn { get; set; }

        [Computed]
        public string DTDRequestRef { get; set; }
        [DisplayName("Status")]
        public int DTDStatusLCID { get; set; }
        public string CollectionPin { get; set; }
    }
}