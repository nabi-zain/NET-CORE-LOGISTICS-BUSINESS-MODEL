using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.CRM.Tables
{
    [Table("Sites")]
    public class Sites
    {
        [Dapper.Contrib.Extensions.Key]
        public int SiteID { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public string SiteName { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public string SiteCustomerName { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public string Address1 { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public string Address2 { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public string Address3 { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public string Address4 { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public string PostalCode { get; set; }

        public int RateAreaID { get; set; }

        public string Longitude { get; set; }
        public string Lattitude { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public string TelNo { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        public string CellNo { get; set; }

        public string What3Words { get; set; }

        public DateTime? LastVerifiedOn { get; set; }
        public int? LastVerifiedBy { get; set; }
        public String Email { get; set; }

        public string Contact { get; set; }
    }
}