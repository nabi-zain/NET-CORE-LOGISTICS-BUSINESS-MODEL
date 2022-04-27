using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_CustomerWaybills_TritonInTouch_Dashboard_Select
    {
        public int CustomerID { get; set; }
        public string AccountCode { get; set; }
        public string CustomerName { get; set; }
        public int DueToday { get; set; }
        public int Delivered { get; set; }
        public int Outstanding { get; set; }
        public int PreviouslyNotDel { get; set; }
        public int OnHold { get; set; }
        public int Late { get; set; }
        public int Late10 { get; set; }
        public int Late12 { get; set; }
        public int Late14 { get; set; }
        public int Late15 { get; set; }
        public int Late17 { get; set; }
        public int Total { get; set; }
    }
}
