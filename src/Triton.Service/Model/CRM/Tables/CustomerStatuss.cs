using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerStatuss")]
    public class CustomerStatuss

    {
        [Key]
        public int CustomerStatusID { get; set; }
        public string FWCode { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Colour { get; set; }

    }
}
