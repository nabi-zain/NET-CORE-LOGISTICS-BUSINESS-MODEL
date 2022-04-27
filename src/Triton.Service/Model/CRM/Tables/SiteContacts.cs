using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.CRM.Tables
{
    [Table("SiteContacts")]
    public class SiteContacts
    {
        [ScaffoldColumn(false)]
        [Dapper.Contrib.Extensions.Key]
        public int SiteContactID { get; set; }

        [ScaffoldColumn(false)]
        public int SiteID { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Cell { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [ScaffoldColumn(false)]
        public bool Active { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedOn { get; set; }

        [ScaffoldColumn(false)]
        public int CreatedByUserID { get; set; }
    }
}