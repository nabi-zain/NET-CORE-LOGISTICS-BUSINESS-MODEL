using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("FWRepMaps")]
    public class FWRepMaps
    {
        [Key]
        public int FWRepMapID { get; set; }
        public int RepCodeID { get; set; }
        public string FWCode { get; set; }
        public bool? Active { get; set; }

    }
}
