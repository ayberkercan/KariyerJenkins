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

        /// <summary>
        /// Bütün ilanları listeleyen endpoint.
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAdverts()
        {
            return Ok(await this.mediator.Send(new GetAllAdvertsQueryRequest()));
        }

        /// <summary>
        /// Parametrik filtre bilgileri ile uygun ilanları listeleyen endpoint.
        /// </summary>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllFilteredAdverts(CheckAllFilteredAdvertsQueryRequest request)
        {
            return Ok(await this.mediator.Send(new GetAllFilteredAdvertsQueryRequest(request)));
        }

        /// <summary>
        /// Oluşturulan ilanların filtreleme nesneleri içeriklerini listeleyen endpoint.
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAvailableFilterProperties()
        {
            return Ok(await this.mediator.Send(new GetAllAvailableFilterPropertiesQueryRequest()));
        }
    }
}
