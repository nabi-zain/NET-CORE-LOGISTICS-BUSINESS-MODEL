using Dapper.Contrib.Extensions;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("EngineerBranchCategoryMaps")]
    public class EngineerBranchCategoryMaps

    {
        [Key]
        public int EngineerBranchCategoryMapID { get; set; }
        public int EngineerID { get; set; }
        public int BranchID { get; set; }
        public int CategoryID { get; set; }
    }
}
