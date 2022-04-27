using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Applications.Tables
{
   public class tblBankCodes
    {
        [Key]
        public int BankID { get; set; }

        [DisplayName("Bank Code")]
        [Required]
        public string BankCode { get; set; }
        [DisplayName("Bank Name")]
        public string BankName { get; set; }
        [DisplayName("Bank Description")]
        public string BankDescription { get; set; }
    }
}
