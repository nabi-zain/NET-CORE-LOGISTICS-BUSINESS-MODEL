using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerGroups")]
    public class CustomerGroupMaps
    {
        public int CustomerGroupMapID { get; set; }
        public int CustomerID { get; set; }
        public int CustomerGroupID { get; set; }
        public byte PrimaryAccount { get; set; }
        public string MapNote { get; set; }

    }
}
