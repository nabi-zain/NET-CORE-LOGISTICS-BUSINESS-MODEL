using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public int Role { get; set; }
        public string Branch { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public int SalesUser { get; set; }
        public int AccidentRole { get; set; }
        public int PORole { get; set; }
        public int PORequester { get; set; }
    }
}
