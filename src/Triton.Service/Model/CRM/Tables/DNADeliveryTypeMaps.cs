using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNADeliveryTypeMaps")]
    public class DNADeliveryTypeMaps
    {
        public long DNADeliveryTypeMapID { get; set; }

        public long DNAID { get; set; }
        public int DeliveryTypeID { get; set; }
    }
}
