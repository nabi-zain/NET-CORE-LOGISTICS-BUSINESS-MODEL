using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Model.Notifications.Tables;

namespace Triton.Model.CRM.Custom
{
    public class CollectionRequestTrackandTracesModel
    {
        public CollectionRequestTrackAndTraces CollectionRequestTrackAndTraces { get; set; }
        public Notification Notification { get; set; }
        public NotificationTypes NotificationTypes { get; set; }
        public FWEventCodes FwEventCodes { get; set; }
        public CollectionRequests CollectionRequests { get; set; }
    }
}
