using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("BranchSizes")]
    public class BranchSizes
    {
        [Key]
        public int BranchSizeID { get; set; }
        public string BranchSize { get; set; }
    }
}
