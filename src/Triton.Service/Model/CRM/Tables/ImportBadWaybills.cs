using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("ImportBadWaybills")]
    class ImportBadWaybills
    {
        [Key]
        public int ImportBadWaybillID { get; set; }
        public string WaybillNo { get; set; }
        public DateTime AttemptedImportDate { get; set; }
    }
}
