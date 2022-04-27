using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Tables
{
    [Table("UserRoutes")]
    public class UserRoutes
    {
        [ScaffoldColumn(false)]
        [Required]
        [Dapper.Contrib.Extensions.Key]
        public int UserRouteID { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public int UserID { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public int RouteID { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public DateTime CreatedOn { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public int CreatedByUserID { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public DateTime? DeletedOn { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public int? DeletedByUserID { get; set; }

        //Additional Properties
        [Write(false)]
        public string User { get; set; }

        [Write(false)]
        public string Route { get; set; }

        [DisplayName("Route Name")]
        [Write(false)]
        public string RouteName { get; set; }

        [DisplayName("Created By")]
        [Write(false)]
        public string CreatedByUsername { get; set; }

        [DisplayName("Deleted By")]
        [Write(false)]
        public string DeletedByUsername { get; set; }
    }
}
