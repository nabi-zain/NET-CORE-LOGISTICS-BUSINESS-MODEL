using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class RepsModels
    {
        public int RepCodeID { get; set; }
        public string RepCode { get; set; }
        public string RepTitle { get; set; }
        public string RepName { get; set; }
        public byte[] FileData { get; set; }
    }

   


   
}
