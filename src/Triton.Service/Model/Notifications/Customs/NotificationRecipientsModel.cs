using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Notifications.Tables;

namespace Triton.Model.Notifications.Customs
{
   public class NotificationRecipientsModel
    {
        public NotificationsRecipients notificationsRecipients { get; set; }
        public Notification Notification { get; set; }

    } 
}
