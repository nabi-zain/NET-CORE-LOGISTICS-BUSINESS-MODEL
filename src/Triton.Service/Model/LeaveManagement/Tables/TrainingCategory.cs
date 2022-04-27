using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("TrainingCategory")]
    public class TrainingCategory
    {
        [Key]
        public int TrainingCategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool Active { get; set; }
        public DateTime TimeDateStamp { get; set; }
    }
}
