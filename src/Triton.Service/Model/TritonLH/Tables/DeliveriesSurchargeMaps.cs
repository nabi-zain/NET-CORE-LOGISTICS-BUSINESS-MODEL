using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesSurchargeMaps")]
    public class DeliveriesSurchargeMap
    {
        [Dapper.Contrib.Extensions.Key]
        public long DeliveriesSurchargeMapID { get; set; } // bigint, not null
        public long DeliveryID { get; set; } // bigint, not null

        public int SurchargeID { get; set; } // int, null

        public int CreatedByUserID { get; set; } // int, not null
        public DateTime CreatedOn { get; set; } // datetime, not null
        public int? DeletedByUserID { get; set; } // int, null
        public DateTime? DeletedOn { get; set; } // datetime, null

    }

}
