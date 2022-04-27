using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Triton.Model.CRM.Tables;

namespace Triton.Model.CRM.Custom
{
    public class StatementModel
    {
        public int customerId{get;set;}
        public  List<Customers> AllowedCustomers {get;set;}
       [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Period { get; set; } = DateTime.Now.AddDays(-28) ;
       // public  GetStatementResponseStatementOutput GetStatementResponseStatementOutput
    }
}