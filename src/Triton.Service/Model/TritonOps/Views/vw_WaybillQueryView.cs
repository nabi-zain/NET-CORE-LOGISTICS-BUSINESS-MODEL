using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Views
{
    public class vw_WaybillQueryView
    {
        [Dapper.Contrib.Extensions.Key]

        public long WaybillQueryMasterID { get; set; }

        [DisplayName("Created On")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime? WaybillMasterCreatedOn { get; set; }

        public long WaybillID { get; set; }

        public int QueryStatusLCID { get; set; }

        public string BranchName { get; set; }

        public int BranchID { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string WaybillNo { get; set; }

        public string Name { get; set; }

        public int LookupcodeID { get; set; }

        public int CreatedByUserID { get; set; }

        public int DeletedByUserID { get; set; }

        [DisplayName("Deleted On")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime? DeletedOn { get; set; }

        public string ConsolidatedQuery { get; set; }

        public int PhoneNumber { get; set; }

        [DisplayName("From Branch")]
        public string FromBranch { get; set; }

        [DisplayName("To Branch")]
        public string ToBranch { get; set; }

        public int ToBranchID { get; set; }

        [DisplayName("From Customer")]
        public string FromSiteCustomerName { get; set; }

        [DisplayName("To Customer")]
        public string ToSiteCustomerName { get; set; }


    }
}
