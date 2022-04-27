using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonGroup.Tables
{
    public class ReportManager 
    {
        [Dapper.Contrib.Extensions.Key]
        public int ReportManagerID { get; set;}
 
        [Required] public string ReportName { get; set;}
 
        [Required] public string ReportDescription { get; set;}

        [Required] public string DisplayName { get; set;}
 
        [Required] public string URL { get; set;}

        [Required] public string PageURL { get; set;}
 
        [Required] public int SystemID { get; set;}
 
        [Required] public int CategoryLCID { get; set;}
 
        [Required] public string RequestedBy { get; set;}
 
        public string RoleID { get; set;}
 
        [Required] public int CreatedByUserID { get; set;}
 
        [Required] public DateTime CreatedOn { get; set;}
 
        public int? DeletedByUserID { get; set;}
 
        public DateTime? DeletedOn { get; set;}
    }
}