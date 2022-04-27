using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("ReportExceptionUserFilters")]
   public class ReportExceptionsUserFilters
    {
        [Key]
        public int UserFilterID { get; set; }
        [DisplayName("Users")]
        [Required]
        public int UserID { get; set; }
        [DisplayName("Branch")]
        [Required]
        public string BranchID { get; set; }
        [Required]
        [DisplayName("Department")]
        public string DepartmentID { get; set; }
        [Required]
        [DisplayName("Group")]
        public string GroupID { get; set; }
        [Required]
        [DisplayName("Company")]
        public string CompanyID { get; set; }
        [Required]
        [DisplayName("Show All Exception")]
        public int ShowAllException { get; set; }

    }
}
