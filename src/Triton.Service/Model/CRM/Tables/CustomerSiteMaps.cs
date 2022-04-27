using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerSiteMaps")]
    public class CustomerSiteMaps
    {
        [Key]
        public int CustomerSiteMapID { get; set; }

        public int CustomerID { get; set; }

        public int SiteID { get; set; }
    }
}
