using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("License")]
    public class License
    {
        [Key]
        public int LicenseID { get; set; }
        [Required]
        public int VehicleID { get; set; }
        [Required]
        public string LicenseNumber { get; set; }
        [Required]
        public DateTime Expiry { get; set; }
        [Required]
        public int CreatedByUserID { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
