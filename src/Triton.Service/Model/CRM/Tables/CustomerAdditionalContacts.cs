using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerAdditionalContacts")]
    public class CustomerAdditionalContacts
    {
        [Key]
        public int CustomerAdditionalContactID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public bool Proposal { get; set; }
        public bool OpsContact { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }

    }
}
