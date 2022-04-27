using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonGroup.Custom
{
    public class CustomerActivityModelIndex
    {
        public List<CustomerActivityModel> CustomerActivities { get; set; }
        public Triton.Model.TritonLH.Tables.Customers Customers { get; set; }
        public Triton.Model.TritonLH.Custom.RepsModels Rep { get; set; }
    }

    public class CustomerActivityModel
    {
        public CustomerActivities CustomerActivity { get; set; }
        public Triton.Model.TritonLH.Tables.Customers Customer { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes CustomerActivityType { get; set; }
    }

    public class CustomerActivityModelCreate
    {
        public CustomerAdditionalContacts CustomerAdditionalContact { get; set; }
        public Triton.Model.TritonLH.Tables.Customers Customer { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> CustomerContactType { get; set; }
    }


}
