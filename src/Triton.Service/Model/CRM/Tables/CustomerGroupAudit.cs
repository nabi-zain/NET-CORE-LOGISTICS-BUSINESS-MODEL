using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerGroupAudit")]
    public class CustomerGroupAudit
    {
        public int CustomerGroupAuditID { get; set; }
        public int PrimaryCustomerID { get; set; }
        public int LinkedCustomerID { get; set; }
        public byte Active { get; set; }

    }
}
