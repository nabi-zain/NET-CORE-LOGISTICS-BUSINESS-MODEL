using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNAInHouseReqMaps")]
    public class DNAInHouseReqMaps
    {
        public long DNAInHouseReqMapID { get; set; }
        public long DNAID { get; set; }

        public int InHouseReqId { get; set; }
        }
    }

