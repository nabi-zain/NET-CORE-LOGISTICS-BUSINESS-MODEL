using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_ShowDeliveriesforInvoicing
    {
        public int CustomerID { get; set; }
        public Int64 TripDeliverID { get; set; }
        public Int64 DeliveryID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime ScheduledDate { get; set; }
        public String CustomerName { get; set; }
        public String FromSite { get; set; }
        public String ToSite { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public Decimal TotalExVat { get; set; }


    }
}
