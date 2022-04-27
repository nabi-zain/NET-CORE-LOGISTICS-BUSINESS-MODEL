using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveMap")]
    public class LeaveMap
    {
        [Key]
        public int LeaveMapId { get; set; }
        public string TotalDays { get; set; }
        public int? MonthId { get; set; }
        public int? LeaveTypeId { get; set; }
        public int? LeaveId { get; set; }
        public DateTime? LmLeavefromdate { get; set; }
        public DateTime? LmLeavetodate { get; set; }
        public string AlBalances { get; set; }
        public string SlBalances { get; set; }
        public string FrBalances { get; set; }
        public string OriginalAlBal { get; set; }
        public string OriginalSlBal { get; set; }
        public string OriginalFrBal { get; set; }
        public string Al { get; set; }
        public string Sl { get; set; }
        public string Fr { get; set; }
        public string Ot { get; set; }
        public string St { get; set; }
        public string Un { get; set; }
        public string Ma { get; set; }
        public string Id { get; set; }
        public string Obr { get; set; }
        public string Con { get; set; }
        public string Tra { get; set; }
        public string Mee { get; set; }
        public string Pto { get; set; }
        public string Ent { get; set; }
        public string Mc { get; set; }
        public string Inh { get; set; }
        public string Err { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string Year { get; set; }
    }
}
