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
    [Table("tblStatus")]
    public    class tblStatus
    {
        [Key]
        public int StatusID { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        [DisplayName("Desription")]
        public string StatusDesc { get; set; }

    }
}
