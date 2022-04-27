using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("RateAreas")]
    public class RateAreas
    {
        [Key]
        public int RateAreaID { get; set; }

        public string ShortCode { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public int MainRateAreaID { get; set; }

        public int RingRateAreaID { get; set; }
    }
}
