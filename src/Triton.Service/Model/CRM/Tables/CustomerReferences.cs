using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerReferences")]
    public class CustomerReferences
    {
        [Key]
        public int CustomerreferenceID { get; set; }
        public int WaybillID { get; set; }
        public string CustomerReference { get; set; }
    }
}
