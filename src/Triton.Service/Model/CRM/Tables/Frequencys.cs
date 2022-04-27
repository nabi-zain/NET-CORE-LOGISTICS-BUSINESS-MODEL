using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("Frequencys")]
    public class Frequencys
    {
        public int FrequencyID { get; set; }
        public string Description { get; set; }
    }
}
