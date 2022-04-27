using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("Frequencys")]
   public class Frequencys
    {
        [Key]
        public int FrequencyID { get; set; }
        public string Description { get; set; }

    }
}
