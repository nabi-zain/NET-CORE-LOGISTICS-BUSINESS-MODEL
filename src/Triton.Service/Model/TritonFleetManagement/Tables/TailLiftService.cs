using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("TailLiftService")]
    public class TailLiftService
    {
        [Key]
        public int TailLiftServiceID { get; set; }
        [Required]
        public int VehicleID { get; set; }
        public string Description { get; set; }
        public DateTime? ServiceDate { get; set; }
        [Required]
        public int CreateByUserID { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
