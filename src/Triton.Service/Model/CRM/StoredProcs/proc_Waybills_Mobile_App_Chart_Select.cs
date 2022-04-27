using System;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_Waybills_Mobile_App_Chart_Select
    {
        public DateTime DelDate { get; set; }
        public decimal Today { get; set; }
        public decimal Delivered { get; set; }
        public decimal Outstanding { get; set; }
        public decimal Queries { get; set; }
        public decimal OutstandingPerc { get; set; }
        public decimal QueriesPerc { get; set; }
        public decimal DelPerc { get; set; }
        public decimal PreviouslyUndel { get; set; }
    }
}
