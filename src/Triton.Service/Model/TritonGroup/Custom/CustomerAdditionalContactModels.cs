using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonGroup.Custom
{
    public class CustomerAdditionalContactModels
    {
        public CustomerAdditionalContacts CustomerAdditionalContact { get; set; }
        public Triton.Model.TritonLH.Tables.Customers Customers { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes CustomerContactType { get; set; }
    }

    public class CustomerAdditionalContactModelsCreate
    {
        public CustomerAdditionalContacts CustomerAdditionalContact { get; set; }
        public Triton.Model.TritonLH.Tables.Customers Customer { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> CustomerContactType { get; set; }
    }


}
