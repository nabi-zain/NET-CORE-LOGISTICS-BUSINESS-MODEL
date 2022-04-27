using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CollectionManifestStatuss")]
    public class CollectionManifestStatuss
    {
        [Key]
        public int CollectionManiferstStatusID { get; set; }
        public int StatusNo { get; set; }
        public string Description { get; set; }
    }
}
