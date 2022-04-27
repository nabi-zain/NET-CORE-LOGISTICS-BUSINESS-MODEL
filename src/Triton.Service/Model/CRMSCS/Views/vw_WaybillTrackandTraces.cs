using System;

namespace Triton.Model.CRMSCS.Views
{
    public class vw_WaybillTrackandTraces
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

        public int Expr1 { get; set; }

        public string Code { get; set; }

        public string ShortDesc { get; set; }

        public string LongDescription { get; set; }

        public string CustomerDesc { get; set; }

        public bool? CustomerActive { get; set; }

        public int? ID { get; set; }

        public int? BranchID { get; set; }

        public string ROUTE { get; set; }

        public string ROUTENAME { get; set; }

        public bool? Agent { get; set; }

        public bool? CCL { get; set; }

        public bool? Depot { get; set; }

        public bool? NoScanner { get; set; }

        public bool? Outlying { get; set; }

        public bool? ScannerInRepairs { get; set; }

        public DateTime? LastUpdated { get; set; }

        public string DepartureTime { get; set; }

        public bool? Active { get; set; }

        public bool? NoScannerRequired { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int? DeletedByUserID { get; set; }
    }
}