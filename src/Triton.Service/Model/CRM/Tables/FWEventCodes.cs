using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("FWEventCodes")]
    public class FWEventCodes
    {
        [Key]
        public int FWEventCodeID { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string ShortDesc { get; set; }
        [Required]
        public string LongDescription { get; set; }
        
        public string CustomerDesc { get; set; }
        
        public Boolean CustomerActive { get; set; }

        public String CustomerEventDropDown {
            get
            {
                return Code + " - " + ShortDesc + " - " + CustomerDesc;
            }

        }
    }
}
