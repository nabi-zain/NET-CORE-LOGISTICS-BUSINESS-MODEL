using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerVOCMaps")]
    public class CustomerVOCMaps
    {
        [Key]
        public int CustomerVOCMapID { get; set; }
        public int CustomerVOCID { get; set; }
        public int VOCCategoryID { get; set; }
        public string Comment { get; set; }
        public int DespatchingBranchID { get; set; }
        public int ReceivingBranchID { get; set; }
        public string WaybillNumbers { get; set; }

    }
}
