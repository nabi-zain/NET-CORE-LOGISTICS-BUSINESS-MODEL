using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerNotificationMaps")]
    public class CustomerNotificationMaps
    {
        [Dapper.Contrib.Extensions.Key]
        public int CustomerNotificationMapID { get; set; }

        [Required]
        [DisplayName("Customer")]
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("FW Event Code")]
        public int FWEventCodeID { get; set; }

        [Required]
        public string Wording { get; set; }

        [Required]
        [DisplayName("Customer E-Mail")]
        public string CustomerEmail { get; set; }

        public int? DeletedByUserID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? DeletedOn { get; set; }

        public int CreatedByUserID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime CreatedOn { get; set; }

    }
}
