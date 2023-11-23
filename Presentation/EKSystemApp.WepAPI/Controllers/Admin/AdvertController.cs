using EKSystemApp.Application.Features.Adverts.Commands.Create;
using EKSystemApp.Application.Features.Adverts.Handler;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Features.Companies.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private readonly IMediator mediator;

        public AdvertController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        #region Bütün ilanları listeleyen endpoint.
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAdverts()
        {
            return Ok(await this.mediator.Send(new GetAllAdvertsQueryRequest()));
        }

        #endregion

        #region Parametrik filtre bilgileri ile uygun ilanları listeleyen endpoint.
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllFilteredAdverts(DateTime startDate,
            DateTime endDate,
            string? positionName,
            string? positionTypeName,
            string? advertPublisherName,
            string? workTypeName,
            string? educationLewelName,
            int advertNumberId)
        {
            var result = await mediator.Send(new GetAllFilteredAdvertsQueryRequest(startDate,
                                                                                        endDate,
                                                                                        positionName,
                                                                                        positionTypeName,
                                                                                        advertPublisherName,
                                                                                        workTypeName,
                                                                                        educationLewelName,
                                                                                        advertNumberId));
            return Ok(result);
        }
        #endregion

        #region Oluşturulan ilanların filtreleme nesneleri içeriklerini listeleyen endpoint.
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAvailableFilterProperties()
        {
            return Ok(await this.mediator.Send(new GetAllAvailableFilterPropertiesQueryRequest()));
        }
        #endregion

    }
}