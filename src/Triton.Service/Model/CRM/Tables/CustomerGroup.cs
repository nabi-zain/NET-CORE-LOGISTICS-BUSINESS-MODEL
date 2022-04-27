using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerGroup")]
    public class CustomerGroup
    {
        public int CustomerGroupID { get; set; }
        public int PrimaryCustomerID { get; set; }

        public int LinkedCustomerID { get; set; }
        public byte Active { get; set; }
    }
}
