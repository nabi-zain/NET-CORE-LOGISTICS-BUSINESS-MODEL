using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("CheckListUserStatus")]
   public class CheckListUserStatus
    {
        [Key]
        [DisplayName("Check List User Status")]
        public int CheckListUserStatusID { get; set; }
        [Required]
        [DisplayName("Check List User")]
        public int CheckListUserID { get; set; }
        [Required]
        public string Complete { get; set; }
        [Required]
        public string comment { get; set; }
        [Required]
        [DisplayName("Created By")]
        public int CreatedBy { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime CreatedOn { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime SystemCreatedOn { get; set; }
    }
}
