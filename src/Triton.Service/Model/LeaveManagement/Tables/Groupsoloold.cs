using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("Groupsoloold")]
    public class Groupsoloold
    {
        [Key] public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }

    }
}
