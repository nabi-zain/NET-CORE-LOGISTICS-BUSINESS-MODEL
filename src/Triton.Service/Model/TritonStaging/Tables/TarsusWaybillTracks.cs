using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonStaging.Tables
{
    [Table("TarsusWaybillTracks")]
    public class TarsusWaybillTracks
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public Int64 TarsusWaybillTrackID { get; set; }

        public Int64 WaybillTrackandTraceID { get; set; }

        public string TarsusShippingID { get; set; }
        public DateTime TransmittedOn { get; set; }
        public Int64 WSBatchID { get; set; }
        public bool wasSuccess { get; set; }
        public string ErrorMsg { get; set; }
    }
}