using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.Members.Cities.Queries
{
    public class GetEbaCityQueryRequest : IRequest<ICollection<EbaStrKvpDto>>
    {
        public int UpKey { get; set; }

        public GetEbaCityQueryRequest(int Upkey)
        {
            this.UpKey = Upkey;
        }
    }
}
