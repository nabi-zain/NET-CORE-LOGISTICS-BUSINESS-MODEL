using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerMeetings")]
    public class CustomerMeetings
    {
        [Dapper.Contrib.Extensions.Key]
        public int CustomerMeetingID { get; set; }
        public int CustomerID { get; set; }
        public DateTime LoggedBy { get; set; }
        public DateTime LoggedOn { get; set; }
        public DateTime DateOfMeeting { get; set; }
        public DateTime TimeOfMeeting { get; set; }
        public string Purpose { get; set; }
        public byte Locked { get; set; }
        public string GeneralComment { get; set; }
        public int MeetingPurposeID { get; set; }
    }
}
