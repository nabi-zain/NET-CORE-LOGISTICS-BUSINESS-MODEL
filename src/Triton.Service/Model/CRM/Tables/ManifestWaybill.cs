using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("ManifestWaybill")]
    public class ManifestWaybill
    {
        [Key]
        public long ManifestWaybillID { get; set; }
        public long ManifestFWID { get; set; }
        public long WaybillFWID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }

    }
}
