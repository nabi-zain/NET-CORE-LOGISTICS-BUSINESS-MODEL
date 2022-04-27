using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    public class VehicleDocument
    {
        [Key]
        public int VehicleDocumentID { get; set; }

        [Required]
        public int BookingID { get; set; }

        [Required]
        public int DocumentRepositoryID { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public int CreatedByUserID { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
