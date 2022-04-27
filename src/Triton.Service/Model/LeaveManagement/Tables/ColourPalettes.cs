using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("ColourPalettes")]
    public class ColourPalettes
    {
        [Key]
        public int ColourPaletteID { get; set; }
        public string ColourDescription { get; set; }
        public string MainPaletteHex { get; set; }
        public string Accent50 { get; set; }
        public string Accent100 { get; set; }
        public string Accent200 { get; set; }
        public string Accent300 { get; set; }
        public string Accent400 { get; set; }
        public string Accent500 { get; set; }
        public string Accent600 { get; set; }
        public string Accent700 { get; set; }
        public string Accent800 { get; set; }
        public string Accent900 { get; set; }
    }
}
