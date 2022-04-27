using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    //Used in the export of DepotToDepot Requests to a text file.
    public class procr_D2DFWExportFile
    {
        public string Data { get; set; }
        public int OrderBy { get; set; }
    }
}
