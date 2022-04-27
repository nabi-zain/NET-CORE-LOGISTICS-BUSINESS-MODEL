using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesSubContractors")]
    public class DeliveriesSubContractors
    {
        [Dapper.Contrib.Extensions.Key]
        public int DeliveriesSubContractorID { get; set; }
        
        [Required]
        public Int64 DeliveryID { get; set; }

        [Required]
        public int PurchaseOrderID { get; set; }

        public string VehicleRegistration { get; set; }

        [Required]
        [DisplayName("Created By")]
        public int CreatedByUserID { get; set; }

        [Required]
        [DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }

        [DisplayName("Deleted On")]
        public DateTime? DeletedOn { get; set; }
    }
}
