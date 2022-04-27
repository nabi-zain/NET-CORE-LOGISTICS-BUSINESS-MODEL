using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerMeetingAttendeeMaps")]
    public class CustomerMeetingAttendeeMaps
    {
        public int CustomerMeetingAttendeeMapID { get; set; }
        public int CustomerMeetingID { get; set; }
        public byte NonTriton { get; set; }
        public int RelevantID { get; set; }
    }
}
