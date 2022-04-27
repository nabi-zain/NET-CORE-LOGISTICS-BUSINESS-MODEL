using System;

namespace Triton.Model.CRMSCS.Tables
{
    public class WaybillTrackandTraces
    {
        public Int64 WaybillTrackandTraceID { get; set; }

        public Int64 WaybillID { get; set; }

        public string NoteNo { get; set; }

        public int? FWEventCodeID { get; set; }

        public string FWEventDescription { get; set; }

        public string FWEventDate { get; set; }

        public string FWEventTime { get; set; }

        public DateTime? EventDateTimeStamp { get; set; }

        public string FWEventLocation { get; set; }

        public string FWEventUser { get; set; }

        public string CrossRef1 { get; set; }

        public string CrossRef2 { get; set; }

        public string CrossRef3 { get; set; }

        public string NoteDetail { get; set; }

        public bool IsMail { get; set; }

        public int? NotificationID { get; set; }

        public int NotificationTypeID { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }
    }
}