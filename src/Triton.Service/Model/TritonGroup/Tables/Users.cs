using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Identity;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("Users")]
    public class Users : IdentityUser
    {
        [Dapper.Contrib.Extensions.Key] public int UserID { get; set; }

        [DisplayName("First name"), Required] public string FirstName { get; set; }

        [DisplayName("Last name"), Required] public string LastName { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public int? EmployeeID { get; set; }

        public int? AppVersion { get; set; }

        public string sAMAccountName { get; set; }

        public string FWUsername { get; set; }

        public int? OldUserID { get; set; }

        [Write(false)] public override string Id { get; set; }
        [Write(false)] public override string NormalizedUserName { get; set; }
        [Write(false)] public override string NormalizedEmail { get; set; }
        [Write(false)] public override string ConcurrencyStamp { get; set; }
        [Write(false)] public override bool TwoFactorEnabled { get; set; }
        [Write(false)] public override DateTimeOffset? LockoutEnd { get; set; }

        // public override bool PhoneNumberConfirmed { get; set; }
    }
}
