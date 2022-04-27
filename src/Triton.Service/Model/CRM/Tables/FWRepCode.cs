using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.CRM.Tables
{
    [Table("FWRepMaps")]
    public class FWRepCode
    {
        public int FWRepMapID { get; set; }
        public int RepCodeID { get; set; }
        public string FWCode { get; set; }
        public byte Active { get; set; }  

    }
}
