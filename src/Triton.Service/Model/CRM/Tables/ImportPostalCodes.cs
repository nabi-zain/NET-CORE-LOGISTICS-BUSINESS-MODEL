using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("ImportPostalCodes")]
    public class ImportPostalCodes
    {
        public  string PostCode { get; set; }
        public  string Name { get; set; }
        public  string Suburb { get; set; }
        public  string RateArea { get; set; }
        public  string Branch { get; set; }
        public  string Route { get; set; }
        public  string RouteDriver { get; set; }
        public  string RouteSubcontractor { get; set; }
        public  string SubcontractorCode { get; set; }
        public  string SubContRateArea { get; set; }
    }
}
