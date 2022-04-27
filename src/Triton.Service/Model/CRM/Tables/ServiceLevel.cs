using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("ServiceLevel")]
    public class ServiceLevel
    {
        public int ServiceLevelID { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
