using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    public class LeadDocuments
    {
        public int DocumentID { get; set; }
        public int LeadID { get; set; }
        public int DocumentCategoryID { get; set; }
        public string ImgName { get; set; }
        public string imgContentType { get; set; }
        public string ImgLenght { get; set; }
        public DateTime DateUpLoaded { get; set; }
        public byte ManualProposal { get; set; }
        public Byte ConfirmedProposal { get; set; }
    }
}
