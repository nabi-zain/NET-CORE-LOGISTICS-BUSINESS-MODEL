using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("SiteScheduleCalendar")]
    public class SiteScheduleCalendar
    {
        [Required, Dapper.Contrib.Extensions.Key]
        public long SiteScheduleCalendarID { get; set; }

        [Required]
        public long SiteScheduleID { get; set; }

        [Required]
        public DateTime ScheduleDate { get; set; }

        public int? EmployeeID { get; set; }

        public int? VehicleID { get; set; }

        public int? Trailer1VehicleID { get; set; }

        public int? Trailer2VehicleID { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedByUserID { get; set; }

        public bool Processed { get; set; }
    }
}
