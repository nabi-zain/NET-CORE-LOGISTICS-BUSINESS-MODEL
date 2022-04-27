using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveType")]
   public class LeaveType
    {
        [Key]
        public int LeaveTypeID { get; set; }
        public string LeaveTypeDescription { get; set; }
        public string LeaveCode { get; set; }
        public string LeaveCodeVip { get; set; }
        public int? LineNumber { get; set; }
        public string FriendlyNameToday { get; set; }
        public string FriendlyNameTomorrow { get; set; }
        public string FriendlyNameMonday { get; set; }
        public string BarchartCode { get; set; }
        public bool? Active { get; set; }
        public string PayoutRatePeople { get; set; }
        public string LeaveTypePeople { get; set; }
        public int? ColourPaletteId { get; set; }
        public string CountryApplicable { get; set; }
    }
}
