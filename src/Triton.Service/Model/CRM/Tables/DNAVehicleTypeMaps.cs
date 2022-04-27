using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNAVehicleTypeMaps")]
    public class DNAVehicleTypeMaps
    {
        public long DNAVehicleTypeMapID { get; set; }
        public long DNAID { get; set; }
        public int VechileTypeID { get; set; }
    }
}
