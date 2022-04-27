using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Triton.Model.CRM.Tables;

namespace  Triton.Model.CRM.Custom
{
    public class CustomerAdjustmentNotesModel
    {
        public CustomerAdjustmentNotes AdjustmentNotes { get; set; }
        public CustomerAdjustments CustomerAdjustments { get; set; }
        public Notifications.Tables.Notification Notification { get; set; }

    }
}
