using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("VendorCode")]
    public class VendorCode
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int VendorCodeID { get; set; }

        [Required]
        public int CompanyID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        public string VendorCodes { get; set; }
     

    }
}
