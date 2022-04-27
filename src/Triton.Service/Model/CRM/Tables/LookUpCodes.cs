using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    public class LookUpCodes
    {
        public int LookUpCodeID { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public string Groups { get; set; }
        public int Sequence { get; set; }
    }
}
