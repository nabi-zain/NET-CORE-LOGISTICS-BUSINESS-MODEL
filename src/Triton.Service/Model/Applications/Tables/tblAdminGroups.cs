using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{                                       
    [Table("tblAdminGroups")]
    public class tblAdminGroups
    {
       
      
        [Key]
        public int ID { get; set; }
        [DisplayName("Admin Group")]
        public int AdminGroupID { get; set; }
        [DisplayName("User")]
        public int UserID { get; set; }
       
      
       
    }
}

