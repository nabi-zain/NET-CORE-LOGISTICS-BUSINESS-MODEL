using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("ImportCustRateAreas")]
    public class ImportCustRateAreas
    {
        public  string CustCode { get; set; }
        public  string RateArea { get; set; }
        public  string RateAreaName { get; set; }
        public  string Depot { get; set; }
        public  string PostalCode { get; set; }
    }
}
