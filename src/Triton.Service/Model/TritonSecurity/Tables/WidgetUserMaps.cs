using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("WidgetUserMaps")]
    public class WidgetUserMaps
    {
        [Dapper.Contrib.Extensions.Key]
        public int WidgetUserMapID { get; set; }
        public int WidgetID { get; set; }
        public int ColumnID { get; set; }
        public int SortNo { get; set; }
        public bool Collapsed { get; set; }
        public int UserID { get; set; }
        public int OwnerSystemID { get; set; }
        public DateTime? DeletedOn { get; set; }

        [Write(false)]
        public Widgets Widgets { get; set; }
    }
}
