using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("JobTitles")]
    public class JobTitles
    {
        [Key]
        public int ID { get; set; }
        public string JobTitleCode { get; set; }
        public string JobTitleLongDesc { get; set; }
        public string JobTitleShortDesc { get; set; }
        public string SkillsEquityField { get; set; }
        public string JobTitleGlTransCode { get; set; }
    }
}
