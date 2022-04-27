using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.NoCommerce.Tables
{
    [Table("CustomerPassword")]
    public class CustomerPassword
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public String Password { get; set; }
        public int PasswordFormatId { get; set; }
        public String PasswordSalt { get; set; }
        public DateTime CreatedOnUtc { get; set; }

    }
}
