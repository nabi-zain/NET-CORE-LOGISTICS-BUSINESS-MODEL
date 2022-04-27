using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("PostalCodeRequests")]
    public class PostalCodeRequests
    {
        [Key]
        public int PostalCodeRequestID { get; set; }

        public int PostalCodeID { get; set; }

        public int ServicedByLookUpCodeID { get; set; }

        public int RateAreaID { get; set; }

        [DisplayName("Known As")]
        public string KnownAs { get; set; }

        public int PostalCdeTransitTimeID { get; set; }

        [DisplayName("Requested On")]
        public DateTime? RequestedOn { get; set; }

        public int RequestedByUserID { get; set; }

        [DisplayName("Approved On")]
        public DateTime? ApprovedOn { get; set; }

        public int ApprovedByUserID { get; set; }

        public int PostalCodeStatusID { get; set; }

        public string BranchName { get; set; }

        public int BranchID { get; set; }

    }
}
