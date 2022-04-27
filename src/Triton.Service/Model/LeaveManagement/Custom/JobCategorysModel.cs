using System;

namespace Triton.Model.LeaveManagement.Custom
{
    public class JobCategorysModel
    {
        public int JobCategoryID { get; set; }
        public string Description { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string  ErrorMessage { get; set; }
    }
}
