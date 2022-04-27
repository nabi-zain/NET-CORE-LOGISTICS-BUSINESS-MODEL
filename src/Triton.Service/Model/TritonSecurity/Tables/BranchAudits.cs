using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("BranchAudits")]
    public class BranchAudits
    {
        [Key]
        public int BranchAuditID { get; set; }

        public int  Branch { get; set; }


        [Required]
        [DisplayName("Total Scanner")]
        public int TotalScanners { get; set; }

        [Required]
        [DisplayName("Total Spare Scanner")]
        public int TotalSpareScanners { get; set; }

        [DisplayName("Created By User")]
        public int CreatedByUserID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime CreatedOn { get; set; }

    }
}
