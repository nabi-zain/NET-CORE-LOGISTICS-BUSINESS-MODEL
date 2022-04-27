using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Tables
{
    [Table("Sitemap")]
    public class Sitemap
    {
        [ScaffoldColumn(false)]
        [Required]
        [Dapper.Contrib.Extensions.Key]
        public int ID { get; set; }
                
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string URL { get; set; }

        [Required]
        public string Roles { get; set; }

        [Required]
        public int Parent { get; set; }

        [Required]
        public string Icon { get; set; }

        [Required]
        public int MVCParentID { get; set; }

        [Required]
        public string MVCUrl { get; set; }        
    }
}
