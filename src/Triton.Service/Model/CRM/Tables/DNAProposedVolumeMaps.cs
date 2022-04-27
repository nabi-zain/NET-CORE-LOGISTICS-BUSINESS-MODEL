using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNAProposedVolumeMaps")]
    public class DNAProposedVolumeMaps
    {
        public long DNAProposedVolumeMapID { get; set; }
        public long DNAID { get; set; }
        public int VolumeID { get; set; }
    }
}
