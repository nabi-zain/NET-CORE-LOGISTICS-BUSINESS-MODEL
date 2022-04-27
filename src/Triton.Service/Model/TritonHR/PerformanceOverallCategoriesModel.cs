using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Table("PerformanceOverallCategories")]
    public class PerformanceOverallCategoriesModel
    {
        [Dapper.Contrib.Extensions.Key]
        public int OverallCatID { get; set; }
        public string OverallCategoryName { get; set; }
        public string Description { get; set; }
    }
}
