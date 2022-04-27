using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNARates")]
    public class DNARates
    {
        public long DNARateID { get; set; }
        public long DNAID { get; set; }
        public int BaseRateID { get; set; }
        public byte Special { get; set; }
        public int Rate { get; set; }
        public int SpecialMinKG { get; set; }
        public int SpecialMinOffset { get; set; }
        public byte Sliding { get; set; }
        public decimal QtyFrom { get; set; }
        public decimal QtyTo { get; set; }
        public int FromAreaID { get; set; }
        public int ToAreaID { get; set; }
        public int NearFromSiteID { get; set; }
        public int NearToSiteID { get; set; }
        public int AdvRateClassID { get; set; }
        public int AdvTransportTypeID { get; set; }
        public int RateYear { get; set; }
        public byte IncMinumum { get; set;}
        public int UniqMinumum { get; set; }
        public int RateDirectionID { get; set; }
        public int BaseKG { get; set; }
        public int BaseMin { get; set; }
        public int BaseRate { get; set; }

    }
}
