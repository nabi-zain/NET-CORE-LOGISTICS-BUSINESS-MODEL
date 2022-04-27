using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Tables
{
    [Table("CCLDepotDeliveryNotes")]
    public class CCLDepotDeliveryNotes
    {
        [ScaffoldColumn(false)]
        [Required]
        [Dapper.Contrib.Extensions.Key]
        public Int64 CCLDepotDeliveryNoteID { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public Int64 CCLID { get; set; }

        [DisplayName("Starting ODO")]
        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public decimal? StartingODO { get; set; }

        [DisplayName("Ending ODO")]
        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public decimal? EndingODO { get; set; }

        [DisplayName("Weight Bridge")]
        [DataType(DataType.Text), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? WeightBridge { get; set; }

        [DisplayName("Break Down")]
        [DataType(DataType.Text), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BreakDown { get; set; }

        [DisplayName("Road Works")]
        [DataType(DataType.Text), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? RoadWorks { get; set; }

        [DataType(DataType.Text), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Other { get; set; }

        [DisplayName("Other KM")]
        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public int? OtherKM { get; set; }

        [DisplayName("Private KM")]
        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public int? PrivateKM { get; set; }

        [DisplayName("End KM")]
        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public decimal? EndKM { get; set; }

        [DisplayName("End Date")]
        [DataType(DataType.Text), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        [DisplayName("Total KM Travelled")]
        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public decimal? TotalKMTravelled { get; set; }

        [DisplayName("Total Litres")]
        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public decimal? TotalLitres { get; set; }

        [DisplayName("KM / Litres")]
        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public decimal? KMLitres { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public int CreatedByUserID { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public DateTime CreatedOn { get; set; }

        //Additional Properties
        //[DisplayName("Routes")]
        //[Write(false)]
        //public string Routes { get; set; }

        //[DisplayName("RouteDate")]
        //[Write(false)]
        //public DateTime? RouteDate { get; set; }

    }
}
