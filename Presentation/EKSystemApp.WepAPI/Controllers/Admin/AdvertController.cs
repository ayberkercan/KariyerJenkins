using EKSystemApp.Application.DTO.File;
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

        #region Yüklenen dosyayı base64 içeriğe dönüştüren endpoint.
        [HttpPost("[action]")]
        public async Task<IActionResult> GetBase64StringFromFile([FromForm] IFormFile file)
        {
            return Ok(await this.mediator.Send(new Base64QueryRequest(file)));
        }
        #endregion

        #region Parametrik base64 metni dosyaya dönüştüren endpoint.
        [HttpPost("[action]")]
        public async Task<IActionResult> GetFileFromBase64String(FileQueryRequest request)
        {
            var fileData = await this.mediator.Send(request);
            return File(fileData.FileBytes, "application/octet-stream", $"{fileData.FileName}");
        }
        #endregion
    }
}