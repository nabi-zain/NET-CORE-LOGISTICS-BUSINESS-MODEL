using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Model.HRM.Tables;

namespace Triton.Service.Model.HRM.Custom
{
    public class EmployeeCourseProviderMapCustomModel
    {
        public Provider Provider { get; set; }
        public Course Course { get; set; }
        public EmployeeCourseProviderMap EmployeeCourseProviderMap { get; set; }
        public Users Users { get; set; }
        public Employees Employees { get; set; }

    }
}
