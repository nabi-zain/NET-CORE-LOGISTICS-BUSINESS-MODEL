using Dapper.Contrib.Extensions;
namespace Triton.Model.CRM.Tables
{
    [Table("CollectionManifestLineItemStatuss")]
    public class CollectionManifestLineItemStatuss
    {
        [Key]
        public int CollectionManifestLineItemStatusID { get; set; }
        public string StatusNo { get; set; }
        public string Description { get; set; }
    }
}
