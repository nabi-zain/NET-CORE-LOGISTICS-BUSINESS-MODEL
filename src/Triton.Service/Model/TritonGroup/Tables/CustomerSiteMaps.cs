using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("CustomerSiteMaps")]
    public class CustomerSiteMaps
    {
        [Key]
        public int CustomerSiteMapID { get; set; }

        public int CustomerID { get; set; }

        public int SiteID { get; set; }

        public int CreatedByUserID { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? DeletedByUserID { get; set; }

        public DateTime? DeletedOn { get; set; }
        [DisplayName("Customer RateArea")]
        public int RateAreaID { get; set; }
    }
}
