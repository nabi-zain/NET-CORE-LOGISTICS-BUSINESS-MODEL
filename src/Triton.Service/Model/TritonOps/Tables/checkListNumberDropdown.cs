using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonOps.Tables
{
    [Table("checkListNumberDropdowns")]
    public class checkListNumberDropdown
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Number")]
        public int number { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int DeletedByUserID { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
