using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("ManifestWaybillMaps")]
    public class ManifestWaybillMaps
    {
        [Key]
        public long ManifestWaybillMapID { get; set; }
        public int? ManifestID { get; set; }
        public long? WaybillID { get; set; }
    }
}
