using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("ImportSpecials")]
    public class ImportSpecials
    {
        public string AccNr { get; set; }
        public string Client { get; set; }
        public string Vol { get; set; }
    }
}
