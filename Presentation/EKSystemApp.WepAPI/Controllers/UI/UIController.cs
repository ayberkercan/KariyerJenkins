using EKSystemApp.Application.Features.Adverts.Commands.Create;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Features.UI.Commands.Create;
using EKSystemApp.Application.Features.UI.Commands.Update;
using EKSystemApp.Application.Features.UI.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.WepAPI.Controllers.UI
{
    [Route("api/[controller]")]
    [ApiController]
    public class UIController : ControllerBase
    {
        private readonly IMediator mediator;

        public UIController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Başvuran aday listeleri içindeki filtre kombinasyonunu kayıtlı aramalarım için kaydeden endpoint.
        /// </summary>
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateSavedFilterOfApprovedCandidate(CreateSavedFilterOfApprovedCandidateCommandRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }

        /// <summary>
        /// Kayıtlı aramalarım içerisindeki bir kaydın başlığını güncelleyen endpoint.
        /// model içindeki id, owner, caption bilgisi verilmesi yeterli ve ~~zorunludur~~.
        /// </summary>
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateSavedFilterOfApprovedCandidate(UpdateSavedFilterOfApprovedCandidateCommandRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }

        /// <summary>
        /// Kullanıcının kayıtlı aramalarım içindeki kayıtlı filtreleri listeleyen endpoint.
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetSavedFiltersOfApprovedCandidateList(CheckAllSavedFiltersOfApprovedCandidateListQueryRequest request)
        {
            return Ok(await this.mediator.Send(new GetAllSavedFiltersOfApprovedCandidateListQueryRequest(request)));
        }
    }
}
