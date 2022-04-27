using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonOps.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonOps.Custom
{
    public class EmployeeGiftsEditModel
    {
        public EmployeeGiftsEditModel EmployeeGiftEditModel { get; set; }
        public Employees Employees { get; set; }
        public orgOrganogram orgOrganogram { get; set; }
        public EmployeeGifts EmployeeGifts { get; set; }
        public CostCentres CostCentres { get; set; }
    }
}
