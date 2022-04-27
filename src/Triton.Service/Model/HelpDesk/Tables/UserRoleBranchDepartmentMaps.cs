using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("UserRoleBranchDepartmentMaps")]
    public class UserRoleBranchDepartmentMaps
    {
        public int UserRoleBranchDepartmentMapID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public int BranchID { get; set; }
        public int DepartmentID { get; set; }
        public string SignatoryTitle { get; set; }
        public int CategoryID { get; set; }
    }
}
