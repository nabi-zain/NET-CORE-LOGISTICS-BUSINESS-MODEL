using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonStaging.Tables
{
    [Table("RWSTrnWaybills")]
    public class RWSTrnWaybills
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public Int64 RWSTrnWaybillsID { get; set; }

        public Int64 WaybillID { get; set; }
        public Int64? RWSWaybillID { get; set; }
        public DateTime TransmittedOn { get; set; }
        public Int64 WSBatchID { get; set; }
        public bool wasSuccess { get; set; }
        public string ErrorMsg { get; set; }
    }
}