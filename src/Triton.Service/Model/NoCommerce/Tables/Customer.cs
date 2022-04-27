using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.NoCommerce.Tables
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
       // public Byte CustomerGUID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
