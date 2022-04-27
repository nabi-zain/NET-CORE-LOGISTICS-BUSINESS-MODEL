using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerBrachs")]
    public class CustomerBranchs
    {
        public int CustomerBranchID { get; set; }
        public int CustomerID { get; set; }
        public byte HeadOffice { get; set; }
        public string Location { get; set; }
    }
}
