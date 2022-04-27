using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblSupplierPaymentTypes")]
    public class tblSupplierPaymentTypes
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int PaymentTypeID { get; set; }
        [Required]
        public string Description { get; set; }

    }
}

