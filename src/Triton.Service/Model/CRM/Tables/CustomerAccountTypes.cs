using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerAccountTypes")]
    public class CustomerAccountTypes
    {
        public int CustomerAccountTypeID { get; set; }
        public string Description { get; set; }
        public string AccountSymbol { get; set; }
    }
}
