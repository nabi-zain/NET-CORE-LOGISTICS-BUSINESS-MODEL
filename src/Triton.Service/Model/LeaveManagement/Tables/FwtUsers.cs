using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("FwtUsers")]
    public class FwtUsers
    {
        public float? ID { get; set; }
        public string CompanyCode { get; set; }
        public string UserID { get; set; }
        public string ActiveIndicator { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmployeeCode { get; set; }
        public string ProfileCode { get; set; }
        public string Position { get; set; }
        public string Branch { get; set; }
        public float? LastLoginDate { get; set; }
        public string UserType { get; set; }
        public string StartupProgram { get; set; }
        public string PasswordExpired { get; set; }
        public string UnixUserIdExists { get; set; }
        public string UserPrimaryFunction { get; set; }
        public string WebUserId { get; set; }
        public string GroupAccount { get; set; }
        public string InternalUser { get; set; }
    }
}
