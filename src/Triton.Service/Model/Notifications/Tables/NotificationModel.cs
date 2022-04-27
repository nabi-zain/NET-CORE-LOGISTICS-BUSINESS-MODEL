using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
     [Table("Notifications")]
    public class NotificationModel
    {
        [Dapper.Contrib.Extensions.Key]
        public long Notificationid { get; set; }
        public int? Oldmessageid { get; set; }
        public int Systemid { get; set; }
        public int Notificationtypeid { get; set; }
        public int Fromuserid { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Submitted { get; set; }
        public int? Notificationclassid { get; set; }
        public int? Notifyuser { get; set; }
        public int? Relatedmessageid { get; set; }
        public int? Parentmessageid { get; set; }
        public int? Oldrelatedmessageid { get; set; }
        public int? Oldparentmessageid { get; set; }
        public int? Reminders { get; set; }
        public string Toreceipients { get; set; }
        public string Ccreceipients { get; set; }
        public string Bccreceipients { get; set; }
        public bool? Senderactioned { get; set; }
        public DateTime? Senderparked { get; set; }
    }
}
