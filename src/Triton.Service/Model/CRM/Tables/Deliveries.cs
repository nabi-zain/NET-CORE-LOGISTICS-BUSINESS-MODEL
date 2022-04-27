using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("Deliveries")]
    public class Deliveries
    {
        [Key]
        public int DeliveryID { get; set; }
        public string DeliveryNo { get; set; }
        public DateTime DeliverySheetDate { get; set; }
        public string DeliveryRoute { get; set; }
        public string DeliveryVehicleRegistration { get; set; }
        public int DeliveryRouteTypeID { get; set; }
        public byte UsedMoblie { get; set; }
    }
}
