using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonGroup.Custom
{
    public class EnquiryModels
    {
        public Triton.Model.TritonGroup.Tables.Enquiries Enquiry { get; set; }
        public Triton.Model.TritonGroup.Tables.Users User { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes Vertical { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes SubVertical { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes Industry { get; set; }

    }

    public class EnquiryCreateModels
    {
        public Triton.Model.TritonGroup.Tables.Enquiries Enquiry { get; set; }
        public Triton.Model.TritonGroup.Tables.Users User { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> Verticals { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> SubVerticals { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> Industrys { get; set; }

    }
}
