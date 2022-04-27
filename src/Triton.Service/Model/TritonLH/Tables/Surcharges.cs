using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.TritonLH.Tables
{
    [Table("Surcharges")]
    public class Surcharges
    {
        [Key]
        public int SurchargeID { get; set; }

        public int SurchargeLCID { get; set; }
        [DisplayName("Date From")]
        public DateTime DateFrom { get; set; }
        [DisplayName("Date To")]
        public DateTime? DateTo { get; set; }
        [DisplayName("Amount Value")]
        public Decimal? AmountValue { get; set; }
        [DisplayName("Amount %")]
        public Decimal? AmountPerc { get; set; }
        [DisplayName("Amount % Ratio")]
        public Decimal? AmountPercRatio { get; set; }

        [DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Created By")]
        public int CreatedByUserID { get; set; }
        [DisplayName("Deleted On")]
        public DateTime? DeletedOn { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }
    }
}