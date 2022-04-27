using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Dapper.Contrib.Extensions.Table("Accesabilitys")]
   public class Accesabilitys
    {
        [Key]
        public int AccesabilityID { get; set; }
        public string Description { get; set; }

    }
}
