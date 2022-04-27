using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("NotificationAttachments")]
  public  class NotificationAttachments
    {
        [DisplayName("Attachment")]
        public int AttachmentID { get; set; }
        [DisplayName("Notification")]
        public int NotificationID { get; set; }
        [DisplayName("Attachment Name")]
        public string Attachmentname { get; set; }
        [DisplayName("Attachment Data")]
        public string AttachmentData { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]
        public DateTime Uploaded { get; set; }
        [DisplayName("Attachment Type")]
        public string AttachmentType { get; set; }
        [DisplayName("Related Notification")]
        public string RelatedNotificationID { get; set; }

    }
}
