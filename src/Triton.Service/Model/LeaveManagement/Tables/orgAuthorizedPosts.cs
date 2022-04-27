using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.LeaveManagement.Tables
{
    [Table("orgAuthorizedPosts")]
    public class orgAuthorizedPosts
    {
        [Key]
        public int authCodeId { get; set; }
        [Required]
        [Display(Name = "Job Profile ID")]
        public int JobProfileID { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string authDescription { get; set; }
        [Required]
        [Display(Name = "Branch ID")]
        public int CostCentreID { get; set; }
        [Required]
        [Display(Name = "Depot ID")]
        public int DepotID { get; set; }
        [Required]
        [Display(Name = "Auth Total")]
        public int authTotal { get; set; }
        [Required]
        [Display(Name = "Auth Status")]
        public bool authActive { get; set; }
        [Required]
        [Display(Name = "Auth Date Stamp")]
        public DateTime authTimeDateStamp { get; set; }
    }
}
