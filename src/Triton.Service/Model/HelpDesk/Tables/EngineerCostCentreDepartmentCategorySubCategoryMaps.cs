using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("EngineerCostCentreDepartmentCategorySubCategoryMaps")]
    public class EngineerCostCentreDepartmentCategorySubCategoryMaps
    {
        [Key]
        public int EngineerCostCenterCategorySubCategoryMapID { get; set; }
        public int EngineerID { get; set; }
        public int CostCentreID { get; set; }
        public int DeaprtmentID { get; set; }
        public int CateogrySubCategoryMapID { get; set; }

    }
}
