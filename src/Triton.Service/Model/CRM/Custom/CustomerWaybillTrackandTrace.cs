using System;

namespace  Triton.Model.CRM.Custom
{
    public class CustomerWaybillTrackandTrace
    {
        //[Dapper.Contrib.Extensions.Key]
        public int WaybillTrackandTraceID { get; set; }

        public long WaybillID { get; set; }
        public string WaybillNo { get; set; }
        public DateTime EventDateTimeStamp { get; set; }
        public string EventCode { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public int FWEventCodeID { get; set; }
        public string CustomerDesc { get; set; }
        public string FWEventLocation { get; set; }

        public int CustomerID { get; set; }
    }
}
