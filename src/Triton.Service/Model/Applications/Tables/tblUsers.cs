using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblUsers")]
     public class tblUsers
     {
        [Dapper.Contrib.Extensions.Key]
        public int UserID { get; set; }

        public string UserName { get; set; }

        public int DepartmentID { get; set; }

        public int BranchID { get; set; }
  

        [DisplayName("Name")]
        public string Name { set; get; }

        [DisplayName("Email")]
        public string EmailAddress { set; get; }

        public string Archive_User { get; set; }

        public int ManagerID { get; set;}

        public int IsHeadOffice { get; set; }

        [Required]
        [DisplayName("StatusID")]
        public int StatusID { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? StatusDate { get; set; }
      
     }
}
