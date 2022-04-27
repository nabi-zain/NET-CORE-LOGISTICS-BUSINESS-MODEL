using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNACurrentVolumeMaps")]
    public class DNACurrentVolumeMaps
    {
        public long DNACurrentVolumeMapID { get; set; }
        public long DNAID { get; set; }
        public int VolumeID { get; set; }
    }
}
