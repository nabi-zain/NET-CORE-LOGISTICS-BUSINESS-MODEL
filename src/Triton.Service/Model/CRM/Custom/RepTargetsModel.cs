using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.LeaveManagement.Tables;
using Triton.Service.Model.CRM.StoredProcs;

namespace Triton.Service.Model.CRM.Custom
{
    public class RepTargetsModel
    {
        public proc_RepTargetsNewBizGrid NewBusinessTargets { get; set; }
        public Uploader Uploader { get; set; }
        public List<proc_RepTargetsNewBizGrid> NewBusinessTargetsList { get; set; }        
    }
}
