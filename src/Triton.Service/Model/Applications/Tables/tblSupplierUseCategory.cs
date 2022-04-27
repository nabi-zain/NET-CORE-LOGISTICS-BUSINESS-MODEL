using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblSupplierUseCategory")]
    public class tblSupplierUseCategory
    {
        [Dapper.Contrib.Extensions.Key]
        public  int SupplierUseCategoryID { get; set; }
        [DisplayName("Category Descripition")]
        [Required]
        public  string CategoryDescription { get; set; }

    }
}

