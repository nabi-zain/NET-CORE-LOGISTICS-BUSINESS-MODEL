using System.ComponentModel;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonCustomers.Tables
{
    [Table("OwinUsers")]
    public class OwinUsers
    {
        [Key]
        public int UserID { get; set; }

        [DisplayName("Username")]
        public string UserName { get; set; }

        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }

        public string PhoneNumberConfirmed { get; set; }

        public string Email { get; set; }

        public string EmailConfirmed { get; set; }
        public string LockoutEndDateUtc { get; set; }
        public string LockoutEnabled { get; set; }
        public string AccessFailedCount { get; set; }

        public int? CustomerID { get; set; }

        public int? AppVersion { get; set; }
    }
}
