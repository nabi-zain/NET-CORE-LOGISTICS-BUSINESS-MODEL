using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNAAccesabilityMaps")]
    public class DNAAccesabilityMaps
    {
        [Key]
        public long DNAAccesabilityMapID { get; set; }
        public long DNAID { get; set; }
        public int AccesabilityID { get; set; }
    }
}
