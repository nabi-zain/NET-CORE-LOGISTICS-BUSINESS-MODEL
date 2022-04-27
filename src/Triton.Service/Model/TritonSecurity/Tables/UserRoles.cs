using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("UserRoles")]
    public class UserRoles
    {
        [Key]
        public int UserRoleID { get; set; }
        public string UserID{get;set;}
        public string RoleID { get; set; }
        public int CompanyID { get; set; }
        public int CostCentreID { get; set; }
        public int DepartmentID { get; set; }
        public int GroupID { get; set; }
        public string IsPermenant { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        public string IsSqlProcessed { get; set; }
        public string Active { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }"  ,ApplyFormatInEditMode=true)]
        public DateTime TimeDateStamp { get; set; }

    }
}
