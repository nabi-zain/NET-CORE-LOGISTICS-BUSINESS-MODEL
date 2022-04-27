using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Service.Model.CRM.Tables
{
    [Table("Tracers")]
    public class Tracers
    {
        [Dapper.Contrib.Extensions.Key]
        public int TracerID { get; set; }

        [Required]
        public int BranchID { get; set; }

        [Required]
        public long WaybillID { get; set; }

        public bool? IsParcel { get; set; }

        [Required]
        public DateTime ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        [Required]
        public int TracerLookUpCodeID { get; set; }

        [Required]
        public int CreatedByUserID { get; set; }

        public int? OriginalTracerID { get; set; }

        public int? ClosedByUserID { get; set; }

        public DateTime? ClosedOn { get; set; }
    }
}
