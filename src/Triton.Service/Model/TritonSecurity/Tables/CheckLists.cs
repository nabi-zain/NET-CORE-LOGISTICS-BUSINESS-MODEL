using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("CheckList")]
   public class CheckLists
    {
        [Key]
        public int PK_CheckListID { get; set; }
        public string Description { get; set; }
        public int DepartmentID { get; set; }
        public int SystemID { get; set; }
        public int FrequencyID { get; set; }
        public string SystemTask { get; set; }


        public int CreatedBy { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime CreatedOn { get; set; }
        [Required]
        public string ReportURL { get; set; }

    }
}
