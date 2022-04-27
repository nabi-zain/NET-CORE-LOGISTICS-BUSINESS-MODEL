using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("PostalCodeAudit")]
    public class PostalCodeAudit
    {
        [Key]
        public int PostalCodeAuditID { get; set; }

        public int PostalCodeID { get; set; }

        public int ServicedByLookUpCodeID { get; set; }

        [DisplayName("Rate Area")]
        public string RateArea { get; set; }

        public int RequestedPostalCodeTransitTimeID { get; set; }

        [DisplayName("Branch Name")]
        public string BranchName { get; set; }

        [DisplayName("Created On")]
        public DateTime? CreatedOn { get; set; }

        [DisplayName("Created By")]
        public int CreatedBy { get; set; }
    }
}
