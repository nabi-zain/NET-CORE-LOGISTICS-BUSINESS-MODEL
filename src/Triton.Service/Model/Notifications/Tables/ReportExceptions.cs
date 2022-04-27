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
    [Table("ReportExceptions")]
    
  public   class ReportExceptions

    {
        [Key]
        public int ReportExceptionID { get; set; }
        [Required]
        [DisplayName("Report Exception Type")]
        public int ReportExceptionTypeID { get; set; }
        [Required]
        [DisplayName("Exception Type")]
        public string ExceptionTypeID { get; set; }
        [Required]
        [DisplayName("Proc name")]
        public string ProcName { get; set; }
        public int SystemID { get; set; }
        public string URL { get; set; }
        public string BranchFilters { get; set; }
        [Required]
        [DisplayName("Department Filters")]
        public string Departmentfilters { get; set; }
        [Required]
        [DisplayName("Additional Command")]
        public string AdditionalCommand { get; set; }
        [Required]
        [DisplayName("Master Active")]
        public string MasterActive { get; set; }
        [DisplayName("Dynamic Report Formatting")]
        [Required]
        public int DynamicReportFormattingID { get; set; }
        public string Alignment { get; set; }
        [DisplayName("Exception Group Order")]
        [Required]
        public int ExceptionGroupOrder { get; set; }
    }
}
