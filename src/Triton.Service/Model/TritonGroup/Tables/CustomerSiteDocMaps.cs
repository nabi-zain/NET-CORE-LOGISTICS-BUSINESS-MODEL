using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("CustomerSiteDocMaps")]
    public class CustomerSiteDocMaps
    {
        [Key]
        public int CustomerSiteDocMapID { get; set; }
        public int CustomerSiteMapID { get; set; }
        public long DocumentCategoryLCID { get; set; }

        public int? DeletedByID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
