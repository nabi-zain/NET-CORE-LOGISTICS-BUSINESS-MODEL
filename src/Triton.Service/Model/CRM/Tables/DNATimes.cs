using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNATimes")]
    public class DNATimes
    {
        public int DNATimeID { get; set; }
        public string Description { get; set; }
    }
}
