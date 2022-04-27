using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliverySite")]
    public class DeliverySite
    {
        [Dapper.Contrib.Extensions.Key]
        public long DeliverySiteID { get; set; }
        public long DeliveryID { get; set; }
        public int CustomerID { get; set; }
        public int CustomerAdditionalContactID { get; set; }

        [DisplayName("From Site")]
        public int FromSiteID { get; set; }

        [DisplayName("To Site")]
        public int ToSiteID { get; set; }

        [DisplayName("Departure Date/Time"), DataType(DataType.DateTime)]
        public DateTime? DepartureDateTime { get; set; }

        [DisplayName("Arrival Date/Time"), DataType(DataType.DateTime)]
        public DateTime? ArrivalDateTime { get; set; }

        [DisplayName("Triton Vehicle")]
        public bool? IsTritonVehicle { get; set; }

        [DisplayName("Trip Type")]
        public int TripTypeLCID { get; set; }

        [DisplayName("Tariff Type")]
        public int TarrifTypeLCID { get; set; }

        public decimal Tonnage { get; set; }

        [DisplayName("Tonnage Amount")]
        public decimal? TonnageAmount { get; set; }

        [DisplayName("Total Ex Vat")]
        public decimal TotalExVAT { get; set; }

        [DisplayName("Customer Order No")]
        public string CustomerOrderNo { get; set; }

        public int? InvoiceID { get; set; }

        public int? StatusLCID { get; set; }

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
