using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerMeetingCSAItemMaps")]
    public class CustomerMeetingCSAItemMaps
    {
        public int CustomerMeetingCSAItemMapID { get; set; }
        public int CustomerMeetingID { get; set; }
        public int CSAFeedbackItemID { get; set; }
        public int CSAFeedbackItemScore { get; set; }

    }
}
