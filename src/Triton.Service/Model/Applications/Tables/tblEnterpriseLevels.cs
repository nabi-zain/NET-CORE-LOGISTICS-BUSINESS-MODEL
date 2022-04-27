using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblEnterpriseLevel")]
    public class tblEnterpriseLevels
    {
        
        
        [Key]
            public int EnterpriseLevelID { get; set; }
        [DisplayName("Enterprise Level")]
        public string EnterpriseLevel { get; set; }
                
    }
    }

