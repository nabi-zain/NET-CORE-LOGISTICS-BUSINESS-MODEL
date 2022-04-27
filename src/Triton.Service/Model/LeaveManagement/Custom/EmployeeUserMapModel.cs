using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonGroup.Tables;

namespace Triton.Model.LeaveManagement.Custom
{
    public class EmployeeUserMapModel
    {
        public EmployeeUserMap EmployeeUserMap { get; set; }
        public Users Users { get; set; }
        public Employees Employees { get; set; }
        public orgOrganogram Organogram { get; set; }
    }
}
