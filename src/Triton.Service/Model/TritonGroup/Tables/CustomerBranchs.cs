using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("CustomerBranchs")]
    public class CustomerBranchs 
    {
        [Dapper.Contrib.Extensions.Key]
        public int CustomerBranchID { get; set; }

        public int CustomerID { get; set; }
        public String Name { get; set; }
        public Boolean HeadOffice { get; set; }
        public String Location { get; set; }

        public String HeadOfficeNiceText 
        { 
            get 
                {
                    string result="";
                    if (HeadOffice)
                         result="Yes";
                    else result="No";
                        
                    return result  ;
                }
        }

               
    }
}

