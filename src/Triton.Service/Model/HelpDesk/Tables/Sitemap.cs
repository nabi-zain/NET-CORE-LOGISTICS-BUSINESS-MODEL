using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("Sitemap")]
    public class Sitemap
    {
        [Dapper.Contrib.Extensions.Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Roles { get; set; }
        public int Parent { get; set; }
        public int OrderBy { get; set; }
    }
}
