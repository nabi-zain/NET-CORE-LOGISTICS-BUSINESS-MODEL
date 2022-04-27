using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("LookupcodeCategories")]
   public class LookUpCategoryModel
    {
        [Dapper.Contrib.Extensions.Key]
        public int LookupcodeCategoryID { get; set; }
        public string Category { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int DeletedByUserID { get; set; }
         public DateTime? DeletedOn { get; set; }
        




 
       
      

    }
}
