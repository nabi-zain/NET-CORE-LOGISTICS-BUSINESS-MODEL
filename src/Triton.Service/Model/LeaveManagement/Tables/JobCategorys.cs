using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("JobCategorys")]
    public class JobCategorys
    {
        [Key]
        public int JobCategoryID { get; set; }
        public string Description { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOn { get; set; }

    }
}
