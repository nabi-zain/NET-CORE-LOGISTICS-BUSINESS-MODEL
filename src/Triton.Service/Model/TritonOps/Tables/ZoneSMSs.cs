using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Model.TritonOps.Tables
{
    [Table("ZoneSMSs")]
    public class ZoneSMSs
    {
        [Key]
        public int ZoneSMSID { get; set; }
        public string ZoneController { get; set; }
        public string RouteName { get; set; }
        [ScaffoldColumn(true)]
        [StringLength(10, ErrorMessage = "10 Numbers Max")]
        public string CellNumber { get; set; }
    }
}
