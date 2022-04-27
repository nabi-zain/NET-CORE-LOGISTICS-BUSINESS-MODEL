using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_SiteSchedule_By_SiteID_Select
    {
        public long SiteScheduleID { get; set; }

        public int FromSiteID { get; set; }

        public int ToSiteID { get; set; }

        public int Week_Day_Number { get; set; }

        public int ScheduleTotal { get; set; }

        public int? Kilometers { get; set; }

        [Required, DisplayName("Departure Time")]
        public string ExpectedDepartureTime { get; set; }

        [Required, DisplayName("Target Consumption Link")]
        public decimal? TargetConsumptionLink { get; set; }

        [Required, DisplayName("Target Consumption 15M")]
        public decimal? TargetConsumption15M { get; set; }

        [Required, DisplayName("Transit Time")]
        public string TransitTime { get; set; }

        public bool Active { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedByUserID { get; set; }

        public string FromSiteCustomerName { get; set; }

        public string ToSiteCustomerName { get; set; }

        public string Week_Day_Name { get; set; }
    }
}
