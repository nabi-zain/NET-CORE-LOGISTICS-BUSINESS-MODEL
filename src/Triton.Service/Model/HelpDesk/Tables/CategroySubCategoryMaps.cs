using System;
using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("CategorySubCategoryMap")]
    public class CategorySubCategoryMaps
    {
        [Key]
        public int CategroySubCategoryMapID { get; set; }
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }

      
    }
}
