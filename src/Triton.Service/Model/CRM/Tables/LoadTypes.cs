using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.CRM.Tables
{
    [Table("LoadTypes")]
    public class LoadTypes
    {
        [Dapper.Contrib.Extensions.Key]
        public int LoadTypeID { get; set; }

        [DisplayName("Load Type")]
        public string LoadType { get; set; }
    }
}
