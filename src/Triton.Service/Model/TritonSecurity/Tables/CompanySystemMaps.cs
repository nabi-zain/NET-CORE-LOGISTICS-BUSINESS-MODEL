using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("CompanySystemMaps")]
   public class CompanySystemMaps
    {
        [Key]
       public int CSMID { get; set; }
        public int SystemID { get; set; }
        public int CompanyID { get; set; }

    }
}
