using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("DashBoredMenu")]
    public class DashboardMenu
    {
        [Key]
        public int  MenuID {get;set;}
        [DisplayName("Menu Name")]
        public string MenuName { get; set; }
        public string Icon { get; set; }
        public int MenuOrder { get; set; }
        public string Link { get; set; }
        public int Tab { get; set; }

    }
}
