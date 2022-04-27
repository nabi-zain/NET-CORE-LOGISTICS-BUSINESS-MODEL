using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblFleetApprovals")]
    public class tblFleetApprovals
    {

       
        [Key]
        public int FleetApprovalID { set; get; }

        [DisplayName("Purchase Order")]
        public int PurchaseOrderID { set; get; }

        [DisplayName("Approved")]
        public bool Approved { set; get; }
        
        [DisplayName("Viewable")]
        public bool Viewable { set; get; }
        

    }
}
