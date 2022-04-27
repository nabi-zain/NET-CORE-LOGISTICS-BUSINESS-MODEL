using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonStaging.Tables
{
    [Table("TorreSIWaybills")]
    public class TorreSIWaybills
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public Int64 TorreSIWaybillID { get; set; }

        public string SINumber { get; set; }
        public string WaybillNo { get; set; }
        public DateTime TransmittedOn { get; set; }
        public Int64 WSBatchID { get; set; }
        public bool wasSuccess { get; set; }
        public string ErrorMsg { get; set; }
        public int CustomerID { get; set; }
    }
}