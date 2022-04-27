using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonStaging.Tables
{
    [Table("TorreWaybills")]
    public class TorreWaybills
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public Int64 TorreWaybillID { get; set; }

        public Int64 WaybillID { get; set; }
        public DateTime TransmittedOn { get; set; }
        public Int64 WSBatchID { get; set; }
        public bool wasSuccess { get; set; }
        public string ErrorMsg { get; set; }
    }
}