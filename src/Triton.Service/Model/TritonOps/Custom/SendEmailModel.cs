using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonOps.Custom
{
    public class SendEmailModel
    {
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string From { get; set; }
        public string Signature { get; set; }
        public string Body { get;set; }
    }
}
