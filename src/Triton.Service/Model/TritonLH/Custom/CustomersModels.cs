using System;
using System.Collections.Generic;
using System.Linq;
using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class CustomersModels
    {
        public Customers Customers { get; set; }

        public Triton.Model.TritonGroup.Tables.CustomerBranchs CustomerBranches { get; set; }
        public Triton.Model.TritonGroup.Tables.CustomerAdditionalContacts AdditionalContacts { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes CustomerStatus { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes CustomerAccountType { get; set; }
        public Triton.Model.TritonSecurity.Tables.Branches Branch { get; set; }
        public Triton.Model.TritonSecurity.Tables.Countrys Country { get; set; }
        public List<Triton.Model.TritonLH.Custom.DeliverySales> Sales { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> TarrifCodes { get; set; }
        public bool isPersisted { get; set; }
    }

    public class CustomersCreateModels
    {
        public Customers Customer { get; set; }
        public List<Triton.Model.TritonSecurity.Tables.Countrys> Countrys { get; set; }
        public List<Triton.Model.TritonSecurity.Tables.Branches> Branches { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> CustomerStatus { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> CustomerAccountTypes { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> TarrifCodes { get; set; }
        public List<Triton.Model.TritonLH.Tables.CustomerTarrifType> CustomerTarrifTypes { get; set; }
    }

    public class CustomersEditModels
    {
        public string Role{ get; set; }
        public Customers Customers { get; set; }

        public Triton.Model.TritonGroup.Tables.CustomerBranchs CustomerBranches { get; set; }
        public Triton.Model.TritonGroup.Tables.CustomerAdditionalContacts AdditionalContacts { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes CustomerStatus { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes CustomerAccountType { get; set; }
        public Triton.Model.TritonSecurity.Tables.Branches Branch { get; set; }
        public Triton.Model.TritonSecurity.Tables.Countrys Country { get; set; }
        public List<Triton.Model.TritonLH.Custom.DeliverySales> Sales { get; set; }
        public List<Triton.Model.TritonLH.Custom.RepsModels> Reps { get; set; }
        public List<Triton.Model.TritonGroup.Custom.NotesModels> Notes { get; set; }
        //public Triton.Model.TritonGroup.Custom.NotesModels Note { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> CustomerStatusList { get; set; }
        public TritonGroup.Tables.Notes CreateNote { get; set; }

        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> TarrifCodes { get; set; }

        public List<Triton.Model.TritonLH.Tables.CustomerTarrifType> CustomerTarrifTypes { get; set; }

        public string CustomerTarrifTypeIDs
        {
            get
            {
                var s = from ct in CustomerTarrifTypes
                        select ct.TarrifTypeLCID;
                return String.Join(",", s.ToArray());
            }
        }

        public bool isPersisted { get; set; }

        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> CustomerDocumentCategories { get; set; }
        public List<Triton.Model.TritonLH.Custom.CustomerRepositoryMaps_DocumentRepository> CustomerDocuments { get; set; }

        public List<Triton.Model.TritonGroup.Custom.DocumentRepositoriesWithLookupCodes> DocsForViewer
        {
            get
            {
                if (CustomerDocuments!=null && CustomerDocuments.Count > 0)
                {
                    List<Triton.Model.TritonGroup.Custom.DocumentRepositoriesWithLookupCodes> docs = new List<TritonGroup.Custom.DocumentRepositoriesWithLookupCodes>();
                    foreach (CustomerRepositoryMaps_DocumentRepository cdoc in CustomerDocuments)
                    {
                        docs.Add(new TritonGroup.Custom.DocumentRepositoriesWithLookupCodes
                        {
                            DocumentRepositories = cdoc.DocumentRepositories,
                            LookUpCodes = cdoc.LookUpCode
                        });
                    }
                    return docs;
                }
                else return null;
            }
        }
    }



}
