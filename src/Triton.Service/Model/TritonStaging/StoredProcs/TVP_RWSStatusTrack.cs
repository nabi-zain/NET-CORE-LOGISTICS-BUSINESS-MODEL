using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonStaging.StoredProcs
{
    public class TVP_RWSStatusTrack
    {
        [Column("WaybillNo")]
        public String WaybillNo { get; set; }
        [Column("RWSStatusID")]
        public long RWSStatusID { get; set; }
        [Column("RWSHubID")]
        public long RWSHubID { get; set; }
        [Column("RWSHub")]
        public string RWSHub { get; set; }
        [Column("RWSTimeStamp")]
        public DateTime RWSTimeStamp { get; set; }
    }
}
