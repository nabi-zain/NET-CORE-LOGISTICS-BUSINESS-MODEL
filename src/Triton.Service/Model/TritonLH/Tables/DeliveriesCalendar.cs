using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesCalendar")]
    public class DeliveriesCalendar
    {
        [Key]
        public long DeliveriesCalendarID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string DriverStatus { get; set; }
        public int? RouteTypeLCID { get; set; }
        public int? StartODO { get; set; }
        public int? EndODO { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
