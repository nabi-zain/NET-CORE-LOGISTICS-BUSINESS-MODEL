using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Systems")]
    public class Systems
    {
        [Dapper.Contrib.Extensions.Key]
        public int SystemID { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string DatabaseName { get; set; }
        public string PrimaryObjectUrl { get; set; }
        public int? HelpDeskEngineerID { get; set; }
        public bool Active { get; set; }
        public string Colour { get; set; }
        public string Icon { get; set; }
    }
}
