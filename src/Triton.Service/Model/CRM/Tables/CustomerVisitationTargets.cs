using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerVisitationTargets")]
    public class CustomerVisitationTargets
    {
        [Key ]
        public int CustomerVisitationTargetID { get; set; }
        public string FWRepCodeType { get; set; }
        public int VisitTarget { get; set; }
        public string VisitTypeDescription { get; set; }
        public DateTime VaildFrom { get; set; }
        public DateTime VaildTo { get; set; }
    }
}
