using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonStaging.Tables
{
    [Table("TorreWaybillTT")]
    public class TorreWaybillTT
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public long TorreWaybillTTID { get; set; }
        public long WaybillTrackandTraceID { get; set; }
        public DateTime DateTransmitted { get; set; }
        public long WSBatchID { get; set; }
        public bool wasSuccess { get; set; }
        public string ErrorMsg { get; set; }
    }
}
