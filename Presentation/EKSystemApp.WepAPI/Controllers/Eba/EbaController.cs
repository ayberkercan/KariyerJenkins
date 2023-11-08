using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Features.EBA.EbaGroups.Queries;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Nest.JoinField;

namespace EKSystemApp.WepAPI.Controllers.Eba
{
    [Route("api/[controller]")]
    [ApiController]
    public class EbaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EbaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Bütün aktif personellerin listelendiği endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var result = await _mediator.Send(new GetEbaEmployeeDetailRequest());
            return Ok(result);
        }

        /// <summary>
        /// Parametrik süreç numarası ile form içeriğini döndüren endpoint
        /// </summary>
        /// <example>50035218</example>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetIseAlimTurkuvazFormDetailsByProcessId(CheckEbaIseAlimFormDetailsQueryRequest request)
        {
            var result = await _mediator.Send(new GetEbaIseAlimFormDetailsQueryRequest(request));
            return Ok(result);
        }

        /// <summary>
        /// Parametrik organizasyon kodu bilgisi ile eBA organizasyon ağaç yapısı içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]/{key?}")]
        public async Task<IActionResult> GetEBAOrganizationTreeById([FromRoute] string key)
        {
            return Ok(await _mediator.Send(new GetEbaOrganizationTreeQueryRequest(key)));
        }

        /// <summary>
        /// eBA organizasyon combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAOrganizations()
        {
            return Ok(await _mediator.Send(new GetEbaOrganizationQueryRequest()));
        }

        /// <summary>
        /// Parametrik organizasyon kodu bilgisi ile eBA grup combobox içeriğini döndüren endpoint
        /// </summary>
        /// <example>50026999</example>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllEBAGroups(CheckEbaGroupQueryRequest request)
        {
            return Ok(await _mediator.Send(new GetEbaGroupQueryRequest(request)));
        }

        /// <summary>
        /// Parametrik grup kodu bilgisi ile eBA bölüm combobox içeriğini döndüren endpoint
        /// </summary>
        /// <example>50035218</example>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllEBADepartments(CheckEbaDepartmentQueryRequest request)
        {
            return Ok(await _mediator.Send(new GetEbaDepartmentQueryRequest(request)));
        }

        /// <summary>
        /// Parametrik bölüm kodu bilgisi ile eBA birim combobox içeriğini döndüren endpoint
        /// </summary>
        /// <example>50035219</example>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetAllEBAUnits(CheckEbaUnitQueryRequest request)
        {
            return Ok(await _mediator.Send(new GetEbaUnitQueryRequest(request)));
        }

        /// <summary>
        /// Parametrik personel bilgileri ile eBA görev combobox içeriğini döndüren endpoint
        /// </summary>
        /// <example>
        ///     "orgId" : 50026999,
        ///     "groupId" : 50035218,
        ///     "departmentId" : 50035219,
        ///     "unitId" : 50035223
        /// </example>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAProfessions(CheckEbaProfessionQueryRequest request)
        {
            return Ok(await _mediator.Send(new GetEbaProfessionQueryRequest(request)));
        }

        /// <summary>
        /// eBA ünvan combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAPositions()
        {
            return Ok(await _mediator.Send(new GetEbaPositionQueryRequest()));
        }

        /// <summary>
        /// eBA kadro türü combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAStaffTypes()
        {
            return Ok(await _mediator.Send(new GetEbaStaffTypeQueryRequest()));
        }


        /// <summary>
        /// eBA çalışma tipi combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAWorkingTypes()
        {
            return Ok(await _mediator.Send(new GetEbaWorkingTypeQueryRequest()));
        }

        /// <summary>
        /// eBA lokasyonlar combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBALocations()
        {
            return Ok(await _mediator.Send(new GetEbaLocationQueryRequest()));
        }

        /// <summary>
        /// eBA cinsiyet combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAGenders()
        {
            return Ok(await _mediator.Send(new GetEbaGenderQueryRequest()));
        }

        /// <summary>
        /// eBA eğitim seviyesi combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAEducationStatuses()
        {
            return Ok(await _mediator.Send(new GetEbaEducationStatusQueryRequest()));
        }

        /// <summary>
        /// eBA askerlik durumu combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAMilitaryStatuses()
        {
            return Ok(await _mediator.Send(new GetEbaMilitaryStatusQueryRequest()));
        }

        /// <summary>
        /// eBA vardiya türü combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAShiftStatuses()
        {
            return Ok(await _mediator.Send(new GetEbaShiftStatusQueryRequest()));
        }

        /// <summary>
        /// eBA yabancı diller combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAForeignLanguages()
        {
            return Ok(await _mediator.Send(new GetEbaForeignLanguagesQueryRequest()));
        }

        /// <summary>
        /// eBA yabancı dil seviyesi combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAForeignLanguageLevels()
        {
            return Ok(await _mediator.Send(new GetEbaForeignLanguageLevelsQueryRequest()));
        }

        /// <summary>
        /// eBA genel yetkinlikler combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAGeneralSkills()
        {
            return Ok(await _mediator.Send(new GetEbaGeneralSkillsQueryRequest()));
        }

        /// <summary>
        /// eBA genel yetkinlik seviyesi combobox içeriğini döndüren endpoint
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAGeneralSkillLevels()
        {
            return Ok(await _mediator.Send(new GetEbaGeneralSkillLevelsQueryRequest()));
        }
    }
}
