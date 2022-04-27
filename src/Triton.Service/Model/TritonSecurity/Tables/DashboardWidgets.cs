using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("DasboardWidgets")]
    public class DashboardWidgets
    {
        [Key]
        public int Widget { get; set; }

        [Required]
        public string WidgetDescription { get; set; }


        public string FirstName { get; set; }

        [Required]
        public string Category { get; set; }


        [Required]
        public string Link {get;set;}

        [Required]
        public string Icon { get; set; }
        [Required]
        public int Area { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public int Height { get; set; }

        [Required]
        public int ColumnWidth { get; set; }
        [Required]
        public int ColumnHeight { get; set; }

    }
}
