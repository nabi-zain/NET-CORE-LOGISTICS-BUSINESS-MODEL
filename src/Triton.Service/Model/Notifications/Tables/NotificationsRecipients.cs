using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.Notifications.Tables
{
    [Table("NotificationsRecipients")]
    public class NotificationsRecipients
    {
        [Dapper.Contrib.Extensions.Key]
        public int NotificationsRecipientsId { get; set; }
        public int NotificationID { get; set; }
        public string RecipientType { get; set; }
        public string RecipientAddress { get; set; }
        public int BeenRead { get; set; }
        public int BeenActioned { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? Parked { get; set; }
    }
}
