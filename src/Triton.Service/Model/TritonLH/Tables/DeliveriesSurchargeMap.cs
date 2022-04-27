using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesSurchargeMaps")]
    public class DeliveriesSurchargeMaps
    {
        [Key]
        public long DeliveriesSurchargeMapID { get; set; }        
        public long DeliveryID { get; set; }        
        public int SurchargeID { get; set; }       
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }


    }
}
