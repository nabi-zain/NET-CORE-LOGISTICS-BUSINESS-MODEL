using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("InsuranceClaimNotes")]
    public class InsuranceClaimNotes
    {
        [Key]
        public int InsuranceClaimNoteID { get; set; }
        public string Note { get; set; }
    }
}
