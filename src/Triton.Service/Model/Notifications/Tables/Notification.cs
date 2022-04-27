using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Notifications.Tables
{
    [Table("Notification")]
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }
        [Required]
        public string OldMessages { get; set; }
        public int SystemID { get; set; }
        [DisplayNameAttribute("Notifications ")]
        public int NotificationTypeID { get; set; }

        [Required]

        public int FromUserID { get; set; }
        [Required]

        public string Subject { get; set; }
        public string Message { get; set; }
        [Required]

        public DateTime Submitted { get; set; }
        [Required]

        public int NotificationClassID { get; set; }
        [Required]

        public int NotifyUser { get; set; }
        [Required]

        public int RelatedMessageID { get; set; }
        [Required]

        public int ParentMessageID { get; set; }
        [Required]

        public int OldRelatedMessageID { get; set; }
        [Required]

        public int OldParentsMessageID { get; set; }
        [Required]

        public int Reminders { get; set; }
        [Required]

        public string ToReceipients { get; set; }
        [Required]


        public string CCReceipients { get; set; }
        [Required]

        public string BCCReceipients { get; set; }
        [Required]

        public string senderActioned { get; set; }
        [Required]

        public DateTime SederParked { get; set; }

    
    }
}
