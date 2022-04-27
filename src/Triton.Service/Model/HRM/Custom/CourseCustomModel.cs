using Triton.Model.TritonGroup.Tables;
using Triton.Service.Model.HRM.Tables;

namespace Triton.Service.Model.HRM.Custom
{
    public class CourseCustomModel
    {
        public Course Course { get; set; }
        public LookUpCodes SkillsDevelopment { get; set; }
    }
}
