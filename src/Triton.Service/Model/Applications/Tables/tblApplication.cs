using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
namespace Triton.Model.Applications.Tables
{
    [Table("tblApplication")]
    public class tblApplication
    {
        [Key]
        public long AppID { get; set; }

        [DisplayName("AppDescription")]
        public string AppDescription { get; set; }

        [DisplayName("Archive_App")]
        public string Archive_App { get; set; }


    }
}
