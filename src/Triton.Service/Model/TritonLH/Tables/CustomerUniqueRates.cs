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
    [Table("CustomerUniqueRates")]
    public class CustomerUniqueRates
    {
        [Dapper.Contrib.Extensions.Key]
        public Int64 CustomerUniqueRateID { get; set; }
        public int CustomerID { get; set; }
        [DisplayName("To RateArea")]
        public int TORateAreaID { get; set; }
        [DisplayName("From RateArea")]
        public int FROMRateAreaID { get; set; }
        [DisplayName("Date Effective")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateEffectiveStart { get; set; }
        [DisplayName("Date Cease")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateEffectiveEnd { get; set; }
        //   [DisplayName("Rate Type")]
        //public int RateTypeLCID   { get; set; }
        [DisplayName("Tarrif Type")]
        public int TarrifTypeLCID { get; set; }

        [DisplayName("Trailer Type")]
        public int LineHaulTrailerTypeLCID { get; set; }
        [DisplayName("Fuel Price")]
        public decimal CurrentFuelPrice { get; set; }
        [DisplayName("Base Rate")]
        public decimal BaseRate { get; set; }
        [DisplayName("Base Fuel")]
        public decimal BaseFuelRate { get; set; }
        [DisplayName("Adj. %")]
        public decimal AdjustPercentage { get; set; }
        //   [Computed]
        //   [DisplayName("Adj. Trip Rate")]
        //public decimal AdjustedTripRate  { get; set; }

        [DisplayName("Aditional Drop")]
        public decimal AdditionalDrop { get; set; }
        [DisplayName("GIT Cover")]
        public decimal GITCover { get; set; }
        [DisplayName("Additional Drop %")]
        public decimal? AdditionalDropPerc { get; set; }

        public int? Tonnage { get; set; }
        public Decimal? TonnageRefRate { get; set; }

        public Decimal? AdjustFuelPercentage { get; set; }


        [Computed]
        [DisplayName("Rate per Ton")]
        public Decimal? RateperTon { get; set; }
        [Computed]
        [DisplayName("Rate per Load")]
        public Decimal? RatePerLoad
        {
            get { return FinalRate * Tonnage; }
        }
        [Computed]
        [DisplayName("Final Rate")]
        public Decimal? FinalRate { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        [DisplayName("Google Kms")]
        public Decimal? GoogleKms { get; set; }

        public Decimal? Consumption { get; set; }
        [DisplayName("Trailer Overhead Cost")]
        public Decimal? TrailerOverheadCost { get; set; }
        [DisplayName("Rate per Km")]
        public Decimal? RateperKm { get; set; }


    }
}
