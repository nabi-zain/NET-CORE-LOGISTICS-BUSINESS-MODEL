using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Views
{
    public class vw_WaybillQuery
    {
        [Dapper.Contrib.Extensions.Key]

        public long WaybillQueryMasterID { get; set; }

        public long WaybillIDMaster { get; set; }

        [DisplayName("Query Created On")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime? WaybillMasterCreatedOn { get; set; }
        public long WaybillID { get; set; }

        public long WaybillQueryID { get; set; }

        public int CreatedByUserID { get; set; }

        [DisplayName("Created By")]
        public string CreatedBy { get; set; }

        public string Email { get; set; }

        [DisplayName("Created On")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime? CreatedOn { get; set; }

        [DisplayName("Deleted On")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime? DeletedOn { get; set; }

        public int UserID { get; set; }

        [DisplayName("User Name")]
        public string UserName { get; set; }

        public string WaybillNo { get; set; }

        [DisplayName("Status")]
        public string Name { get; set; }

        [DisplayName("Note")]
        public string Comment { get; set; }

        public string Query { get; set; }

        public string Resolution { get; set; }

        [DisplayName("Note Created By")]
        public long CreatedByID { get; set; }

        public int CustomerNote { get; set; }

        public int FWEventCodeID { get; set; }

        public string FWEventLocation { get; set; }

        public string FWEventUser { get; set; }

        public string FWNoteRef { get; set; }

        [DisplayName("Date Created")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime? TimeStamp { get; set; }

        [DisplayName("Branch")]
        public string BranchName { get; set; }

        public int QueryStatusLCID { get; set; }

        public int DeletedByUserID { get; set; }



    }
}
