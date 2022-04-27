using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CSAFeedBackItems")]
    public class CSAFeedBackItems
    {

        public int CSAFeedBackItemID { get; set; }
        public string CSAFeedBackItemDescription { get; set; }
        public int CSACategoryID { get; set; }
        public int OrderBy { get; set; }
    }
}
