using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Model.HRM.Tables;
using Users = Triton.Model.TritonSecurity.Tables.Users;

namespace Triton.Service.Model.HRM.Custom
{
    public class RecruitmentCustomModel
    {
        public JobProfiles JobProfile { get; set; }
        public Departments Departments { get; set; }
        public Branches Branches { get; set; }
        public LookUpCodes LookUpCodes { get; set; }
        public Recruitment Recruitment { get; set; }
        public Users Users { get; set; }

    }
}
