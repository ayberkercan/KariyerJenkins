using EKSystemApp.Application.DTO.Eba.TMP;
using MediatR;

namespace EKSystemApp.Application.Features.Members.Provinces.Queries
{
    public class GetEbaProvinceQueryRequest : IRequest<ICollection<EbaStrKvpDto>>
    {
        public string UpKey { get; set; }

        public GetEbaProvinceQueryRequest(string Upkey)
        {
            this.UpKey = Upkey;
        }
    }
}
