using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("CostCenterTelephoneExtensionMap")]
    public class CostCenterTelephoneExtensionMap
    {
        public int CCTID { get; set; }
        public long UserID { get; set; }
        public int DepotID { get; set; }
        public string CctTelephoneExtension { get; set; }
        public bool CctActive { get; set; }
        public DateTime CctDateTimeStamp { get; set; }
    }
}
