using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("SubCategorys")]
    public class SubCategorys
    {
        [Key]
        public int SubCategoryID { get; set; }
        public string Description { get; set; }
    }
}
