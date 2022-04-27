using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_Waybills_ExpectedDeliveries
    {
        [DisplayName("Prev Delivered")]
        public int PreviouslyDelivered { get; set; }

        [DisplayName("Failed")]
        public int Failed { get; set; }

        [DisplayName("Due Today")]
        public int ExpectedForToday { get; set; }

        [DisplayName("Due In 1 HR")]
        public int DueInHour { get; set; }

        [DisplayName("Depot")]
        public int Depot { get; set; }

        [DisplayName("No Delivery Sheet")]
        public int NoDeliverySheets { get; set; }

        [DisplayName("Overdue")]
        public int Overdue { get; set; }

        [DisplayName("Total Deliveries")]
        public int TotalDeliveries { get; set; }

        [DisplayName("Delivered")]
        public int Delivered { get; set; }

        [DisplayName("Prev Undelivered")]
        public int PreviouslyUndelivered { get; set; }

        [DisplayName("BranchID")]
        public int BranchID { get; set; }

        [DisplayName("Branch Name")]
        public string BranchFullName { get; set; }
    }
}
