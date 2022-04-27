using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class ContactTypeModel
    {       
        public int ContactTypeIDManagement { get; set; }
               
        public int ContactTypeLCIDManagement { get; set; }
        public int? CustomerIDManagement { get; set; }
        public string NameManagement { get; set; }
        public string TelephoneNumberManagement { get; set; }
        public string EmailManagement { get; set; }
        public int ContactTypeIDOperations { get; set; }

        public int ContactTypeLCIDOperations { get; set; }
        public int? CustomerIDOperations { get; set; }
        public string NameOperations { get; set; }
        public string TelephoneNumberOperations { get; set; }
        public string EmailOperations { get; set; }

        public int ContactTypeIDAccounts { get; set; }

        public int ContactTypeLCIDAccounts { get; set; }
        public int? CustomerIDAccounts { get; set; }
        public string NameAccounts { get; set; }
        public string TelephoneNumberAccounts { get; set; }
        public string EmailAccounts { get; set; }
    }
}
