using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonStaging.Tables
{
    [Table("DeviceWaybill")]
    public class DeviceWaybill
    {
        [Dapper.Contrib.Extensions.Key] public long DeviceWaybillID { get; set; }
        [Required] public long WaybillID { get; set; }
        [Required] public int WaybillStatusID { get; set; }
        public DateTime? PODDateTimeStamp { get; set; }
        public string PODReceivedBy { get; set; }
        public string Comment { get; set; }
        [Required] public string Route { get; set; }
        [Required] public bool isSynced { get; set; }
        [Required] public int CreatedByUserID { get; set; }
        [Required] public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
