using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerMeetingMintues")]
    public class CustomerMeetingMinutes
    {
        public int CustomerMeetinMintueID { get; set; }
        public int CustomerMeetingID { get; set; }
        public string Mintue { get; set; }
        public string ActionBy { get; set; }
        public int Actioner { get; set; }
        public DateTime ActionbyDate { get; set; }
    }
}
