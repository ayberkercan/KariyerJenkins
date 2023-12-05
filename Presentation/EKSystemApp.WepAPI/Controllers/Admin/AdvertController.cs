using EKSystemApp.Application.Features.Adverts.Queries;
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

        [HttpPost("[action]")]
        public async Task<IActionResult> GetAdvertById(GetAllFilteredAdvertsQueryRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }

        #region Parametrik filtre bilgileri ile uygun ilanları listeleyen endpoint.
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllFilteredAdverts(GetAllFilteredAdvertsQueryRequest request)
        {
            return Ok(await this.mediator.Send(request));
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