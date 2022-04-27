using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerCommionTypes")]
    public class CustomerCommisionTypes
    {
        public int CustomerCommisionTypeID { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
    }
}
