using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPOBatchDetails")]
    public class tblPOBatchDetails
    {
        [Key]
        public int BatchDetailsID { get; set; }

        public string BatchHeaderID { get; set; }
        [Required]
        public int CellNo { get; set; }

        [Required]
        public string PukNo { get; set; }
        [Required]
        public string Batch { get; set; }
        [Required]
        public string UserID { get; set; }
        [Required]
        public string UserCode { get; set; }
        [Required]
        public string Billing { get; set; }
        [Required]
        public string Allowance { get; set; }
        [Required]
        public string StaffAdvBlackberry { get; set; }
        [Required]
        [DisplayName("Charge TO Salary")]
        public string ChargeToSalary { get; set; }
        [Required]
        public string Allocation { get; set; }
        [Required]
        public int ExcludingVAT { get; set; }

       
    }
}