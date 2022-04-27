using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("Sites")]
    public class Sites
    {
        [Dapper.Contrib.Extensions.Key]
        public int SiteID { get; set; }

        [DisplayName("Code")]
        public string SiteName { get; set; }

        [DisplayName("Site Name")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string SiteCustomerName { get; set; }

        [DisplayName("Address 1")]
        public string Address1 { get; set; }
        [DisplayName("Address 2")]
        public string Address2 { get; set; }
        [DisplayName("Address 3")]
        public string Address3 { get; set; }

        public string City { get; set; }
        [DisplayName("Postal")]
        public string Zip { get; set; }

        public int? StateAcronymID { get; set; }

        public int? CountryID { get; set; }

        [DisplayName("Tel No")]
        public String PhoneNumber { get; set; }

        [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString = "{0:##.000000}")]
        public decimal? Latitude { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:##.000000}")]
        public decimal? Longitude { get; set; }

        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        [DisplayName("Rate Area")]
        public int? RateAreaID { get; set; }
        [DisplayName("Province")]
        public int? ProvinceLCID { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }

        public int? LastVerifiedBy { get; set; }
        public DateTime? LastVerifiedOn { get; set; }

        public string What3Words { get; set; }
    }
}
