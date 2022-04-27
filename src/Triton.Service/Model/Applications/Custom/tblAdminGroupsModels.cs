using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblAdminGroupsModels
    {
      public  tblAdminGroups adminGroups { get; set; }
        public tblAdminGroup adminGroup { get; set; }
       
       public tblUsers user { get; set; }

        
    }


}
