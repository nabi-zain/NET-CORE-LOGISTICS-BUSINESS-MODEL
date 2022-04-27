namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_CCLEmployeeVehicleMap_FTL_Employee_Select
    {
        public int EmployeeID { get; set; }

        public string EmployeeAlias { get; set; }

        public bool Assigned { get; set; }

        public string Name { get; set; }

        public int JobProfileID { get; set; }

        public string JobProfile { get; set; }

        public byte[] FileData { get; set; }

        public string BranchFullName { get; set; }

    }
}
