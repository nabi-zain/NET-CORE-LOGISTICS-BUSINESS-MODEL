using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPeriods")]
   public class tblPeriods
    {
       
        public int PeriodID { get; set; }
        
        public string Description { set; get; }
        
    }
}
