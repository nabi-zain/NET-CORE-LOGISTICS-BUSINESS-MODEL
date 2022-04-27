using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblAdminGroup")]
    public class tblAdminGroup
    {
        [Dapper.Contrib.Extensions.Key]
        public int AdminGroupID { get; set; }

        [DisplayName("Group Name")]
        public string GroupName { get; set; }
        [Required]
        public int GroupStatus { get; set; }
        

    }
}
