using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerBranchContactMaps")]
    public class CustomerBranchContactMaps
    {
        [Key]
        public int CustomerBrachConTactMap { get; set; }
        public int CustomerAddistionalContactID { get; set; }
        public int CustomerBranchID { get; set; }
    }
}
