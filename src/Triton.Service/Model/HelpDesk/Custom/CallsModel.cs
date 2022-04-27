using System.Collections.Generic;
using Triton.Model.HelpDesk.StoredProcs;
using Triton.Model.HelpDesk.Tables;
using Triton.Model.TritonSecurity.Tables;
using Users = Triton.Model.TritonSecurity.Tables.Users;

namespace Triton.Model.HelpDesk.Custom
{
    public class CallsModel
    {
        public Calls  Calls { get; set; }
        public Branches Branches { get; set; }
        public Departments Departments { get; set; }
        public Users Users { get; set; }
        public Priority Priority { get; set; }
        public CategorySubCategoryMaps CategroySubCategoryMap { get; set; }
        public Status Status { get; set; }
        public Engineers Engineers { get; set; }
        public SubCategoryFailureSources SubCategoryFailureSources { get; set; }

    }

    public class CallsEditModel
    {
        public CallsModel CallsModel { get; set; }
        public List<Branches> Branches { get; set; }
        public List<Users> Userses { get; set; }
        public List<Priority> Priorities { get; set; }
        public  List<CategorySubCategoryMaps> CategroySubCategoryMapses { get; set; }
        public List<Categorys>Categoryses { get; set; }
        public List<SubCategorys> SubCategoryses { get; set; }
        public List<Status> Statuses { get; set; }
        public List<Engineers> Engineerses { get; set; }
        public List<Departments> Departmentse { get; set; }
        public List<SubCategoryFailureSources> SubCategoryFailureSourceses { get; set; }
        public GetEmployeeByUserID GetEmployeeByUserId { get; set; }
    }

    public class CallSearchModel
    {
        public List<CallsModel> CallsModel { get; set; }
        public List<Branches> Branches { get; set; }
        public List<Departments> Departmentses { get; set; }
        public List<Users> Userses { get; set; }
        public List<Priority> Priorities { get; set; }
        public List<CategorySubCategoryMaps> CategorySubCategoryMapses { get; set; }
        public List<Status> Statuses { get; set; }
        public List<Engineers> Engineerses { get; set; }
        public List<SubCategoryFailureSources> SubCategoryFailureSourceses { get; set; }
    }

}
