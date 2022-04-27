using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("ContactType")]
    public class ContactType
    {
        [Key]
        public int ContactTypeID { get; set; }

        [Required]
        public int ContactTypeLCID { get; set; }
        public int? CustomerID { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }

    }
}
