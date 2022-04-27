using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblMater_Roles")]
    public class tblMaster_Roles
    {


        [Key]
        
        public string Role_Name { set; get; }
    }
}
