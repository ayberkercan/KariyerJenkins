using EKSystemApp.Application.DTO.Advert.List;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Queries
{
    public class GetAllFilteredAdvertsQueryRequest : IRequest<ICollection<AdvertListDto>>
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? PositionName { get; set; }
        public string? PositionTypeName { get; set; }
        public string? AdvertPublisherName { get; set; }
        public string? WorkTypeName { get; set; }
        public string? EducationLevelName { get; set; }
        public int? AdvertNumberId { get; set; }

        public GetAllFilteredAdvertsQueryRequest(
            DateTime? startDate, 
            DateTime? endDate, 
            string? positionName,
            string? positionTypeName,
            string? advertPublisherName, 
            string? workTypeName, 
            string? educationLewelName, 
            int? advertNumberId
            )
        {
            StartDate = startDate;
            EndDate = endDate;
            PositionName = positionName;
            PositionTypeName = positionTypeName;
            WorkTypeName = workTypeName;
            AdvertPublisherName = advertPublisherName;
            WorkTypeName = workTypeName;
            EducationLevelName = educationLewelName;
            AdvertNumberId = advertNumberId;
        }
    }
}
