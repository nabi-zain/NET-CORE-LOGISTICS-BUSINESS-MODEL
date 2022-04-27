using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonOps.Views
{
    public class vw_PostalCodeSearch
    {
        [Dapper.Contrib.Extensions.Key]

        public int PostalCodeID { get; set; }

        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }

        public string Name { get; set; }

        public string Suburb { get; set; }
        
        [DisplayName("Rate Area")]
        public string RateArea { get; set; }

        public int RateAreaID { get; set; }

        [DisplayName("Branch Code")]
        public string BranchCode { get; set; }

        [DisplayName("Bay Number")]
        public string BayNo { get; set; }

        [DisplayName("Bay Name")]
        public string BayName { get; set; }

        [DisplayName("Bay Route")]
        public string BayRoute { get; set; }

        [DisplayName("Known As")]

        public string KnownAs { get; set; }

        public int ServicedByLookUpCodeID { get; set; }

        public int PostalCodeTransitTimeID { get; set; }

        public int PostalCodeStatusID { get; set; }
        
        public int ApprovalUserID { get; set; }

        [DisplayName("Actioned On")]
        public DateTime? ActionedOn { get; set; }

        public bool Active { get; set; }

        public int PostalCodeRequestID { get; set; }

        [DisplayName("Km's From Branch")]
        public int KMsFromBranch { get; set; }

        [DisplayName("Transit Time")]
        public string TransitTime { get; set; }

        [DisplayName("Serviced By")]
        public string ServicedBy { get; set; }

        [DisplayName("Branch Full Name")]
        public string BranchFullName { get; set; }

        [DisplayName("Rate Area Branch")]
        public string RateAreaBranch { get; set; }

        [DisplayName("Branch Alias")]
        public string BranchAlias { get; set; }
        
        
    }
}
