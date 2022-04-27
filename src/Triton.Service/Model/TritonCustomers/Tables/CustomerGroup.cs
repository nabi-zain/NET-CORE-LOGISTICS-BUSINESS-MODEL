using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonCustomers.Tables
{
    [Table("CustomerGroup")]
    public class CustomerGroup
    {
        [Key]
        public int CustomerGroupID { get; set; }
        public int PrimaryCustomerID { get; set; }
        public int LinkedCustomerID { get; set; }
        public bool Active { get; set; }
    }
}
