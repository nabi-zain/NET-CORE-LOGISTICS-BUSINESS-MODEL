using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Tables
{
    [Table("CCLDieselFills")]
    public class CCLDieselFills
    {
        [ScaffoldColumn(false)]
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public int CCLDieselFillID { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public long CCLID { get; set; }

        [DisplayName("Trip Type Lookup")]
        public int? TripTypeLookUpCodeID { get; set; }

        [DataType(DataType.Text)]
        public string Bowser { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public decimal? KM { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public decimal? Litres { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Cash/Card Lookup")]        
        public int? CashCardLookUpCodeID { get; set; }

        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "{0} must be a Number.")]
        public decimal? Amount { get; set; }

        [ScaffoldColumn(false)]
        public int? CreatedByUserID { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedOn { get; set; }

        //Additional Properties
        [DisplayName("Trip Type")]
        [Write(false)]
        public string TripTypeName { get; set; }

        [DisplayName("Cash/Card")]
        [Write(false)]
        public string CashCardName { get; set; }
    }
}
