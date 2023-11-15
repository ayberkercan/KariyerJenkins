namespace EKSystemApp.Application.Features.EBA.TMP.Queries
{
    public class CheckEbaFormDetailsQueryRequest// : IRequest<buraya yazılacak>
    {
        public int ProcessId { get; set; }
        public CheckEbaFormDetailsQueryRequest(int ProcessId)
        {
            this.ProcessId = ProcessId;
        }
    }
}
