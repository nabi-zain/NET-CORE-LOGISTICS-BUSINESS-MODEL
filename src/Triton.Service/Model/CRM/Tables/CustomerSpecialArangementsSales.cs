using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerSpecialArangementsSales")]
    public class CustomerSpecialArangementsSales
    {
        [Dapper.Contrib.Extensions.Key]
        public int CustomerSpecialArangementSalesID { get; set; }
        public int CustomerID { get; set; }
        public bool isCSAAccount { get; set; }
        public bool hasStaff { get; set; }
        public int NoofGeneralWorkers { get; set; }
        public int NoofInHouseControllers { get; set; }
        public bool hasEquipment { get; set; }
        public string ZebraPrinterSerial { get; set; }
        public string WaybillPrinterSerial { get; set; }
        public bool hasConsolidation { get; set; }
        public bool isSharedAccount { get; set; }
        public int RepCode1 { get; set; }
        public int RepCode2 { get; set; }
        public int RepCode3 { get; set; }
        public string SpecialInvoicingInstructions { get; set; }



    }
}
