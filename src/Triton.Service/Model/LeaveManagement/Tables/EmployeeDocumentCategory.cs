using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("EmployeeDocumentCategory")]
    public class EmployeeDocumentCategory
    {
        [Key]
        public int EmployeeDocumentCategoryID { get; set; }
        public string Description { get; set; }
    }
}
