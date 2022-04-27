using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerSpecialArangements")]
    public class CustomerSpecialArangements
    {
        [Required, Dapper.Contrib.Extensions.Key]
        public int CustomerSpecialArangementID { get; set; }

        [Required]
        public int CustomerID { get; set; }
        public DateTime? CeaseDate { get; set; }
        public string Minumums { get; set; }
        public decimal? DocFee { get; set; }
        public bool DocFeeIncl { get; set; }
        public decimal? FuelSurcharge { get; set; }
        public bool HasRingRates { get; set; }
        public string Discounts { get; set; }
        public bool HasSpecialInsurance { get; set; }
        public bool Consolidate { get; set; }
        public string MinimumRands { get; set; }
        public bool MinumumsInc { get; set; }
        public int? CrossborderVolume { get; set; }
    }
}
