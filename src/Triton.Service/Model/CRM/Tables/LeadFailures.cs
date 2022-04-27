using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("LeadFailures")]
    public class LeadFailures
    {
        public int LeadFailureID { get; set; }
        public string Description { get; set; }
        public int? OppositionID { get; set; }
    }
}
