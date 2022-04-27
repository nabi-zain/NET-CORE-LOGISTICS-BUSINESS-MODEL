using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("RecuringTask")]
   public class RecuringTask
    {
        [Dapper.Contrib.Extensions.Key]
        public int RecuringTaskID { get; set; }
        public string Descripition { get; set; }
        public int TimeFrequencyID { get; set; }
        public int EngineerID { get; set; }
        public int BranchID { get; set; }
        public int PriorityID { get; set; }
        public byte Active { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime LastUsed { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }
    }
}
