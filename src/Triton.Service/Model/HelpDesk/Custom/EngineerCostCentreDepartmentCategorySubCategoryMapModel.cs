using Triton.Model.HelpDesk.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.HelpDesk.Custom
{
    public class EngineerCostCentreDepartmentCategorySubCategoryMapModel
    {
        public EngineerCostCentreDepartmentCategorySubCategoryMaps EngineerCostCentreDepartmentCategorySubCategoryMaps
        {
            get;
            set;
        }
        public Engineers Engineers { get; set; }
        public CostCentres CostCentres { get; set; }
        public Departments Departments { get; set; }
        public CategorySubCategoryMaps CategroySubCategoryMaps { get; set; }
        public Categorys Categorys { get; set; }
    }
}
