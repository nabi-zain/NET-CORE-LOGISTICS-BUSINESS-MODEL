using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("CustomerAdditionalContacts")]
    public class CustomerAdditionalContacts
    {
        [Key]
        public int CustomerAdditionalContactID { get; set; }

        public int? CustomerID { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public string Tel { get; set; }

        public string Fax { get; set; }

        public string Cell { get; set; }

        public string Email { get; set; }

        public bool Proposal { get; set; }

        [DisplayName("Contact Type")]
        public int? ContactTypeLookupCodeID { get; set; }
    }
}
