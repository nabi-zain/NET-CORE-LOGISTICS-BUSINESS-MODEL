using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesRepositoryMaps")]
    public class DeliveriesRepositoryMaps
    {
        [Key]
        public int DeliveriesRepositoryMapID { get; set; }
        public long DeliveryID { get; set; }
        public long DocumentRepositoryID { get; set; }
    }
}
