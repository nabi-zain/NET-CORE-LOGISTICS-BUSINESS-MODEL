using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("FolderSettings")]
    public class FolderSettings
    {
        [Key]
        public int ID { get; set; }
        public string FolderLocation { get; set; }
    }
}
