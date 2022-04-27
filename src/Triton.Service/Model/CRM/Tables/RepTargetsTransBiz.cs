using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Service.Model.CRM.Tables
{
    [Table("RepTargetsTransBiz")]
    public class RepTargetsTransBiz
    {
        [Dapper.Contrib.Extensions.Key]
        public int RepTargetsTransBizID { get; set; }
        [Display(Name = "Rep Code")]
        public string RevRepCode { get; set; }
        [Display(Name = "Target")]
        public decimal? Target { get; set; }
        [Display(Name = "Financial Month")]
        public int? FinancialMonth { get; set; }
        [Display(Name = "Financial Year")]
        public int? FinancialYear { get; set; }
        [Display(Name = "Actual Rep ID")]
        public int? ActualRepID { get; set; }
        [Required]
        [Display(Name = "Branch ID")]
        public int BranchID { get; set; }
        [Required]
        [Display(Name = "Created On")]
        public int CreatedOn { get; set; }
        [Required]
        [Display(Name = "Created By User ID")]
        public int CreatedByUserID { get; set; }
        [Display(Name = "Deleted On")]
        public int DeletedOn { get; set; }
        [Required]
        [Display(Name = "Deleted By User ID")]
        public int DeletedByUserID { get; set; }
    }
}
