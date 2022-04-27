using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("SiteSchedule")]
    public class SiteSchedule
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public long SiteScheduleID { get; set; }

        [Required, DisplayName("From Site")]
        public int FromSiteID { get; set; }

        [Required, DisplayName("To Site")]
        public int ToSiteID { get; set; }

        [Required, DisplayName("Week Number")]
        public int Week_Day_Number { get; set; }

        [Required, DisplayName("Schedule Total")]
        public int ScheduleTotal { get; set; }

        public int? Kilometers { get; set; }

        [Required, DisplayName("Departure Time")]
        public string ExpectedDepartureTime { get; set; }

        [Required, DisplayName("Target Consumption Link")]
        public decimal? TargetConsumptionLink { get; set; }

        [Required, DisplayName("Target Consumption 15M")]
        public decimal? TargetConsumption15M { get; set; }

        [Required, DisplayName("Transit Time (Hours)")]
        public int? TransitTime { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required, DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [Required, DisplayName("Created By")]
        public int CreatedByUserID { get; set; }
    }
}
