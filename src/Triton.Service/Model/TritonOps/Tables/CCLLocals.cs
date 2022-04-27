using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Tables
{
    [Table("CCLLocals")]
    public class CCLLocals
    {
        [ScaffoldColumn(false)]
        [Required]
        [Dapper.Contrib.Extensions.Key]
        public int CCLLocalID { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public long CCLID { get; set; }

        [DisplayName("Locals")]
        public int LocalLookUpCodeID { get; set; }

        [DisplayName("Customer")]
        [Required]
        public int CustomerID { get; set; }

        [DisplayName("Departure Date/Time")]
        //[DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DepartureDateTime { get; set; }

        [DisplayName("Arrival Date/Time")]
        //[DataType(DataType.Text), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? ArrivalDateTime { get; set; }

        [DisplayName("From KM")]
        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public int? FromKM { get; set; }

        [DisplayName("To KM")]
        [RegularExpression(@"^\d+$", ErrorMessage = "{0} must be a Number.")]
        public int? ToKM { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public int? CreatedByUserID { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public DateTime? CreatedOn { get; set; }

        //Additional Properties
        [ScaffoldColumn(false)]
        [DisplayName("Customer")]
        [Write(false)]
        public string CustomerName { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Local")]
        [Write(false)]
        public string LocalNumber { get; set; }
    }
}
