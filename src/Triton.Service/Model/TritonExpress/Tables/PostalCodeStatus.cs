using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("PostalCodeStatus")]
    public class PostalCodeStatus
    {
        [Key]
        public int PostalCodeStatusID { get; set; }

        public string Description { get; set; }
    }
}
