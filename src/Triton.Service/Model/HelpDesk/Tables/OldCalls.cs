using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("OldCalls")]
    public class OldCalls
    {
        [Dapper.Contrib.Extensions.Key]
        public long CallID { get; set; }
        public string CallerID { get; set; }
        public int BranchID { get; set; }
        public string UserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime TimeofCall { get; set; }
        public string ProblemDescription { get; set; }
        public int PriorityID { get; set; }
        public int CategoryID { get; set; }
        public byte Resolved { get; set; }
        public string Resolution { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public  DateTime TimeOfResolution { get; set; }
        public string ResolvedUser { get; set; }
        public int StatusID { get; set; }
        public int EngineerID { get; set; }

    }
}
