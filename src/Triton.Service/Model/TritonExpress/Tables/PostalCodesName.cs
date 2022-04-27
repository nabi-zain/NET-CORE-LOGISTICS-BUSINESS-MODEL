using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("PostalCodesName")]
    public class PostalCodesName
    {
        [Key]
        public string Town { get; set; }
        public string PostalCode { get; set; }
        public string RateArea { get; set; }
        public string TransitTime { get; set; }

    }
}
