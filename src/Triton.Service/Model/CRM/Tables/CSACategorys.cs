using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CSACategorys")]
    public class CSACategorys
    {
        [Key]
        public int CSACateogryID { get; set; }
        public string CSACategoryName { get; set; }
        public string CSACategoryDescription { get; set; }

    }
}
