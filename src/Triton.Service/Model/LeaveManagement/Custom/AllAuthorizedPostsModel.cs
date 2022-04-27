using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Triton.Service.Model.LeaveManagement.Custom
{
    public class AllAuthorizedPostsModel
    {
        [Display(Name = "Auth Code ID")]
        public int authCodeId { get; set; }
        [Display(Name = "Description")]
        public string AuthDescription { get; set; }
        [Display(Name = "Branch Full Name")]
        public string BranchFullName { get; set; }
        [Display(Name = "Auth Total")]
        public int AuthTotal { get; set; }
        [Display(Name = "Auth Status")]
        public bool AuthStatus { get; set; }
        [Display(Name = "Job Profile ID")]
        public int JobProfileID { get; set; }
        [Display(Name = "Cost Centre ID")]
        public int CostCentreID { get; set; }
        [Display(Name = "Depot ID")]
        public int DepotID { get; set; }
        [Display(Name = "Created On")]
        public DateTime AuthTimeDateStamp { get; set; }
    }
}
