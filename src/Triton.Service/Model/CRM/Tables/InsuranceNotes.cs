using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("InsuranceNotes")]
    public class InsuranceNotes
    {
        [Key]
        public int InsuranceNoteID { get; set; }
        public string Note { get; set; }
        public bool? Active { get; set; }
        public bool? NextIncrease { get; set; }
        public int? OrderBy { get; set; }
    }
}
