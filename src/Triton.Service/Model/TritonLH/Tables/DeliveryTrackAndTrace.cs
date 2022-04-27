using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveryTrackAndTrace")]
    public class DeliveryTrackAndTrace
    {
        [Dapper.Contrib.Extensions.Key]
        public long DeliveryTrackAndTraceID { get; set; } // bigint, not null
        public long DeliveryID { get; set; } // bigint, not null
        public int DeliveryTrackAndTraceTypeLCID { get; set; } // int, not null
        public DateTime DeliveryTrackAndTraceDateTime { get; set; } // datetime, not null
        public int CreatedByUserID { get; set; } // int, not null
        public DateTime CreatedOn { get; set; } // datetime, not null

        public string MessageSent { get; set; }

        //public string Latitude { get; set; }
        //public string Longitude { get; set; }
    }

}
