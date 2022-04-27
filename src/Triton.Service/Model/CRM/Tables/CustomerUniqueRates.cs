using System;
using System.Security.AccessControl;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerUniqueRates")]
    public class CustomerUniqueRates
    {
        [Key]
        public int CustomerUniqueRateID { get; set; }

        public int CustomerID { get; set; }

        public DateTime? DateEffectiveStart { get; set; }

        public DateTime? DateEffectiveEnd { get; set; }

        public bool isAccountLinked { get; set; }

        public string FWRateAcct { get; set; }

        public int? BaseClassID { get; set; }

        public int? BaseRateID { get; set; }

        public int? Insurance { get; set; }

        public int? ServiceTypeID { get; set; }

        public int? RateTypeID { get; set; }

        public int? LoadTypeID { get; set; }

        public int? FromRateAreaID { get; set; }

        public int? ToRateAreaID { get; set; }

        public int? Minumum { get; set; }

        public int? UniqueVolumeID { get; set; }

        public int RateDirectionID { get; set; }
        public Guid UniqueID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CountryID { get; set; }
    }
}
