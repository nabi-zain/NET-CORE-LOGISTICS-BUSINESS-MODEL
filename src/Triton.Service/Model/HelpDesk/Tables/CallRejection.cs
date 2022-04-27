using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("CallRejections")]
    public class CallRejection
    {
        [Dapper.Contrib.Extensions.Key]
        public int CallRejectionID { get; set; }
        public long CallID { get; set; }
        public int RejectctedByID { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Timeofrejection { get; set; }
        public string Reason { get; set; }
    }
}
