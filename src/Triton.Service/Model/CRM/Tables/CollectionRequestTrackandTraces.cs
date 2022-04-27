using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CollectionRequestTrackandTraces")]
    public class CollectionRequestTrackAndTraces
    {
        [Key]
        public long CollectionRequestTrackandTraceID { get; set; }
        public long CollectionRequestID { get; set; }
        public string NoteNo { get; set; }
        public int FWEventCodeID { get; set; }
        public string FWEventDescription { get; set; }
        public string FWEventDate { get; set; }
        public string FWEventTime { get; set; }
        public DateTime EventDateTimeStamp { get; set; }
        public string FWEventLocation { get; set; }
        public string FWEventUser { get; set; }
        public string NoteDetail { get; set; }
        public byte IsMail { get; set; }
        public int NotificationID { get; set; }
        public int NotificationTypeID { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string PulsitLongitude { get; set; }
        public string PulsitLattitude { get; set; }
        public DateTime PulsitDateTimeStamp { get; set; }
    }
}
