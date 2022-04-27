using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("SubCategoryFailureSources")]
    public class SubCategoryFailureSources
    {
        [Key]
        public int SubCategoryFailureSourceID { get; set; }
        public int Description { get; set; }
    }
}
