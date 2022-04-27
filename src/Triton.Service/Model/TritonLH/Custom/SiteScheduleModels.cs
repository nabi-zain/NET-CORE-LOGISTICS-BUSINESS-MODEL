using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class SiteScheduleFromToSites
    {
        public SiteSchedule SiteSchedule { get; set; }
        public Sites FromSite { get; set; }
        public Sites ToSite { get; set; }
    }

    public class SiteScheduleCalendarModel
    {
        public SiteSchedule SiteSchedule { get; set; }
        public SiteScheduleCalendar SiteScheduleCalendar { get; set; }
        public Sites FromSite { get; set; }
        public Sites ToSite { get; set; }
    }
}
