using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{

    [Table("Roles")]
    public class RolesModel
    {
        //public int CreatedByUserID;
        [Dapper.Contrib.Extensions.Key] //Roles Table identifier
        public int RoleID { get; set; }
        [DisplayName("Role Name")]
        public string RoleName { get; set; }
        public string Description { get; set; }
        [Write (false)]
        [Computed]
        public int UserID { get; set; }
        [Write(false)]
        [Computed]
        public string UserName { get; set; }
        [Write(false)]
        [Computed]
        public string EmailAddress { get; set; }
        [Write(false)]
        [Computed]
        public int CreatedByUserID { get; set; }
        [Write(false)]
        [Computed]
        public DateTime  CreatedOn { get; set; }

    }
}
