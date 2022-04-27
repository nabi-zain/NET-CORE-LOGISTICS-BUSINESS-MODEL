using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("BranchCategorys")]
   public class BranchCategorys
    {
        [Key]
        public int BranchCategoryID { get; set; }
        public string Description { get; set; }

    }
}
