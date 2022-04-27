using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("CheckListUsers")]
   public  class CheckListUsers
    {
        [Key]
        public int CheckListUserID { get; set; }
        [Required]
        public int CheckListID { get; set; }
        public int UserID { get; set; }
        [Required]
        public int PersonAccountableUserID { get; set; }
        [Required]
        public int PersonReponsibaleUserID { get; set; }
        public int CreatedBY { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime CreatedOn { get; set; }

    }
}
