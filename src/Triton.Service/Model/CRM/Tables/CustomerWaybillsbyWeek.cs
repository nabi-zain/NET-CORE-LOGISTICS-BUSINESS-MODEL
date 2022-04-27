using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.CRM.Tables
{
    [Dapper.Contrib.Extensions.Table("CustomerWaybillsbyWeek")]
    public class CustomerWaybillsbyWeeks
    {
        [Key]
        public long CustomerWaybillsbyWeek { get; set; }
        public int TotalQty { get; set; }
        public decimal TotalMass { get; set; }
        public decimal TotalVolume { get; set; }
        public decimal ChargeMass { get; set; }
        public decimal FreightValue { get; set; }
        public decimal DocumentationFee { get; set; }
        public decimal ChargesSubTotal { get; set; }
        [Column( "Calendar_Year")]
        public int CalendarYear { get; set; }
        [Column( "Fiancial_Year ")]
        public int FiancialYear { get; set; }
        public int WayBills { get; set; }
        public int CustomerID { get; set; }
        [Column( "Calendar_Week")]
        public byte CalendarWeek { get; set; }
        [Column( "Financial_Week")]
        public byte FinancialWeek { get; set; }
        public string Service { get; set; }
        public DateTime DateRecorded { get; set; }
        public byte isNew { get; set; }
        public DateTime WhenFirstNew { get; set; }
    
    }
}
