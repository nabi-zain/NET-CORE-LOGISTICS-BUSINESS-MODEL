using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("OutworksCommission")]
    public class OutworksCommission
    {
        [Key]
        public int OutworksCommissionID { get; set; }
        public string SupplierDescription { get; set; }
        public string PONumber { get; set; }
        public int? Quantity { get; set; }
        public bool Isssued { get; set; }
        public decimal? CostExVAT { get; set; }
        public decimal? SellingPrice { get; set; }
        public int BookingID { get; set; }
        public int VehicleID { get; set; }
        public bool IsOutworksCommission { get; set; }
        public int CreatedBy { get; set; }
        public string Note { get; set; }
    }
}
