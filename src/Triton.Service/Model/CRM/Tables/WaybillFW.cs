using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("WaybillFW")]
    public class WaybillFW
    {
        [Dapper.Contrib.Extensions.Key]
        public long WaybillFWID { get; set; }
        public string WaybillNo { get; set; }
        public DateTime WaybillDate { get; set; }
        public long ManifestFWID { get; set; }
        public int CustomerID { get; set; }
        public int ToBranchID { get; set; }
        public int? SendCustomerSitemapID { get; set; }
        public int? ReceiveCustomerSitemapID { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public decimal Qty { get; set; }
        public decimal Mass { get; set; }
        public int ServiceTypeID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
    }
}
