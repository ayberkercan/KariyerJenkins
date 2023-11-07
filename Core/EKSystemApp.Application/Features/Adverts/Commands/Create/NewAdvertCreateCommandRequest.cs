using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Domain.Entities.Admin.Eba;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Commands.Create
{
    public class NewAdvertCreateCommandRequest:IRequest<CreateAdvertDto>
    {
        public string WorkDefination { get; set; }
        public string PublicQuality { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Logo { get; set; }
        public int PeriotNumberId { get; set; }
        public int AdwertNumberId { get; set; }
        public ICollection<object> Positions { get; set; }
    }
}
