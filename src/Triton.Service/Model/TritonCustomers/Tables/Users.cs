using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.TritonCustomers.Tables
{
    [Table("Users")]
    public class Users
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public int CustomerID { get; set; }
        public int LookUpCodeID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
