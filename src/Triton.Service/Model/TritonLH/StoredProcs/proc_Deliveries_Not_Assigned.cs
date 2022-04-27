using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Deliveries_Not_Assigned
    {
        [DisplayName("Scheduled Date")]
        [DisplayFormat(DataFormatString = "{dddd, MMMM d, yyyy")]
        public DateTime ScheduledDate { get; set; }

        [DisplayName("Total Outstanding")]
        public int TotalOutstanding { get; set; }

        [DisplayName("After 12")]
        public int UnassignedAfter12 { get; set; }
    }
}
