using System.ComponentModel;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.CRM.Tables
{
    [Dapper.Contrib.Extensions.Table("CustomerWaybillsbyQuarters")]
    public class CustomerWaybillsbyQuarter
    {
        [Key]
        public long CustomerWaybillsbyQuarterID { get; set; }
        public int TotalQty { get; set; }
        public decimal TotalMass { get; set; }
        public decimal TotalVolume { get; set; }
        public decimal ChargeMass { get; set; }
        public decimal FreightValue { get; set; }
        public decimal FuelSurcharge { get; set; }
        public decimal DocumentationFee { get; set; }
        public decimal ChargsSubTotal { get; set; }
        [Column("Calendar_Year")]
        public int Calendar_Year { get; set; }
        [Column("Finacial_Year")]
        public int Financial_Year { get; set; }
        [Column( "Calendar_Quarter")]
        public byte Calendar_Quarter { get; set; }
        [Column("Financial_Quarter")]
        public byte Financial_Quarter { get; set; }
        public int Waybills { get; set; }
        public int CustomerID { get; set; }
        public string Service { get; set; }

    }
}
