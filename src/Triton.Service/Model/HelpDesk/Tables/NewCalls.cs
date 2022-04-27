using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("NewCalls")]
    public class NewCalls
    {
        [Dapper.Contrib.Extensions.Key]
        public long CallID { get; set; }
        public int CallerEmployeeID { get; set; }
        public int BranchID { get; set; }
        public int DepartmentID { get; set; }
        public long UserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime TimeOfCall { get; set; }
        public string ProblemDescription { get; set; }
        public int PriorityID { get; set; }
        public int CategorySubCategoryMapID { get; set; }
        public byte Resolved { get; set; }
        public string Resolution { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime TimeOfResolution { get; set; }
        public long ResolvedUserID { get; set; }
        public int StatusID { get; set; }
        public int EngineerID { get; set; }
        public int SubCategoryFailureSourceID { get; set; }
    }
}
