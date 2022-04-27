using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("PostalCodeTransitTime")]
    public class PostalCodeTransitTime
    {
        [Key]
        public int PostalCodeTransitTimeID { get; set; }
        public string Description { get; set; }
    }
}
