using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Triton.Model.TritonOps.Tables
{
    [Table("BadCargo")]
    public class BadCargo
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]

        public int BadCargoID { get; set; }
        public int CategoryID { get; set; }
        public int CustomerID { get; set; }
        public int BranchID { get; set; }
        [DisplayName("Waybill No")]
        public string WaybillNo { get; set; }
        public decimal Volume { get; set; }
        [DisplayName("Total Mass")]
        public decimal TotalMass { get; set; }
        [DisplayName("Charge Mass")]
        public decimal ChargeMass { get; set; }
        public string Comments { get; set; }
        public DateTime? DateSaved { get; set; }
        public int UserID { get; set; }
        public bool Saved { get; set; }

    }
}
