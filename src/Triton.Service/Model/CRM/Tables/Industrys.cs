using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("Industrys")]
    public class Industrys
    {
        [Key]
        public int IndustryID { get; set; }
        public string Description { get; set; }
        public string ShortDesc { get; set; }
    }
}
