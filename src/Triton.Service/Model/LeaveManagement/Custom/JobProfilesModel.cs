using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.LeaveManagement.Tables;

namespace Triton.Model.LeaveManagement.Custom
{
    public class JobProfilesModel
    {
        public JobProfiles jobProfiles { get; set; }
        public List<JobCategorys> JobCategorys { get; set; }
        public string ErrorMessage { get; set; }
        public int SelectedJoCategoryID { get; set; }
    }
}
