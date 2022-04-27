using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonLH.Tables
{
    [Table("CustomerRepositoryMaps")]
    public class CustomerRepositoryMaps
    {
        [Key]
        public int CustomerRepositoryMapID { get; set; }
        public long CustomerID { get; set; }
        public long DocumentRepositoryID { get; set; }
    }
}
