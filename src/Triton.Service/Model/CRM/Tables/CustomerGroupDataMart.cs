using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerGroupDataMart")]
    public class CustomerGroupDataMart
    {
        [Key]
        public int CustomerGroupDataMartID { get; set; }
        public string GroupName { get; set; }
        public int CustomerID { get; set; }
    }
}
