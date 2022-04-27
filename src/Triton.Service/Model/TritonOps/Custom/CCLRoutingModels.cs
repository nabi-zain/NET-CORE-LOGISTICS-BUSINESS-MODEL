using Triton.Model.TritonOps.Tables;

namespace Triton.Model.TritonOps.Custom
{
    public class CCLRoutingModels
    {
        public class CCLRoutingWithImages
        {
            public CCLRoutings CCLRoutings { get; set; }

            public CCLImageRepository CCLImageRepository { get; set; }

            public LookUpCodes LookUpCodes { get; set; }
        }

       
    }
}
