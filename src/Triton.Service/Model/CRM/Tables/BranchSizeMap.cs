using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Dapper.Contrib.Extensions.Table("BranchSizeMap")]
    public class BranchSizeMap
    {
        [Key]
        public int BranchSizeMapID { get; set; }
        public int BranchSizeID { get; set; }
        public int BranchID { get; set; }
    }
}
