using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonStaging.Tables
{
    [Table("WSBatchs")]
    public class WSBatchs
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public Int64 WSBatchID { get; set; }

        public string ServiceName { get; set; }
        public DateTime DateTransmitted { get; set; }
    }
}