using System;

namespace Triton.Model.CRM.Custom
{
    public class WaybillTrackandTracesModel
    {
        public int WaybillTrackandTraceID { get; set; }
        public long WaybillID { get; set; }
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
        public bool SMSSent { get; set; }
        public string PulsITLongitude { get; set; }
        public string PulsITLatitude { get; set; }
        public DateTime? PulsITDateTimeStamp { get; set; }
        public string Code { get; set; }
        public string ShortDesc { get; set; }
        public string LongDescription { get; set; }
        public string CustomerDesc { get; set; }
        public bool? CustomerActive { get; set; }
    }
}
