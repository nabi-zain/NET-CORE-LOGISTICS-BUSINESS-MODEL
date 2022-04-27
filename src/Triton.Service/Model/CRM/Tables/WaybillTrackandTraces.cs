using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;


namespace Triton.Model.CRM.Tables
{
    [Table("WaybillTrackandTraces")]
    public class WaybillTrackandTraces 
    {

        [Dapper.Contrib.Extensions.Key]
        public virtual int WaybillTrackandTraceID { get; set; }

        public virtual long WaybillID { get; set; }
        public virtual string NoteNo { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm tt}")]
        public virtual DateTime EventDateTimeStamp { get; set; }
        public virtual bool IsMail { get; set; }
        public virtual int NotificationID { get; set; }
        public virtual int FWEventCodeID { get; set; }
        public virtual int NotificationTypeID { get; set; }
        public virtual string FWEventLocation { get; set; }
        public virtual string FWEventUser { get; set; }
        public virtual string FWEventDate { get; set; }
        public virtual string FWEventTime { get; set; }
        public virtual string CrossRef1 { get; set; }
        public virtual string CrossRef2 { get; set; }
        public virtual string CrossRef3 { get; set; }
        public virtual string NoteDetail { get; set; }
        public virtual string Longitude { get; set; }
        public virtual string Latitude { get; set; }

    }
}
