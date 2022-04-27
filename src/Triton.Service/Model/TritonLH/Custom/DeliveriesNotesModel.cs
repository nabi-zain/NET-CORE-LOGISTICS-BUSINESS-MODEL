using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonLH.Tables;
using Triton.Model.TritonGroup.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class DeliveriesNotesModel
    {
        public DeliveriesNotes DeliveriesNotes { get; set; }

        public Users Users { get; set; }

        public LookUpCodes LookUpCodes { get; set; }
    }
}
