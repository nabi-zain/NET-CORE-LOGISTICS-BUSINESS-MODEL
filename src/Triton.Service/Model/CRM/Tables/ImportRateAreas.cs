using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("ImportRateAreas")]
    public class ImportRateAreas
    {
        public string RateArea { get; set; }
        public string Description { get; set; }
        public  string ShortDescription { get; set; }
        public  string Proximity { get; set; }
        public  string Depot { get; set; }
    }
}
