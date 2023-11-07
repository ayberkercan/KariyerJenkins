using EKSystemApp.Application.Features.AdPublishers;
using EKSystemApp.Application.Features.AdQuestions.Questions;
using EKSystemApp.Application.Features.AdStatuses.Queries;
using EKSystemApp.Application.Features.EBA.EBACompanies.Queries;
using EKSystemApp.Application.Features.EBA.EbaDepartments.Queries;
using EKSystemApp.Application.Features.EBA.EbaGroups.Queries;
using EKSystemApp.Application.Features.EBA.EbaLocations.Queries;
using EKSystemApp.Application.Features.EBA.EbaPositions.Queries;
using EKSystemApp.Application.Features.EBA.EbaUnits.Queries;
using EKSystemApp.Application.Features.EducationLevels.Queries;
using EKSystemApp.Application.Features.ExperiencePeriods.Queries;
using EKSystemApp.Application.Features.ForignLanguages.Queries;
using EKSystemApp.Application.Features.JobCategories.Queries;
using EKSystemApp.Application.Features.MillitaryStatuses.Queries;
using EKSystemApp.Application.Features.PositionsTypes.Queries.List;
using EKSystemApp.Application.Features.SkillAndExpertises.Queries;
using EKSystemApp.Application.Features.TasksTypes.Queries.List;
using EKSystemApp.Application.Features.WorkModels.Queries;
using EKSystemApp.Application.Features.WorkTypes.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EKSystemApp.WepAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewAdvertCreateController : ControllerBase
    {

        private readonly IMediator mediator;

        public NewAdvertCreateController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBACompany()
        {
            return Ok(await this.mediator.Send(new GetEBACompaniesQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBADepartment()
        {
            return Ok(await this.mediator.Send(new GetEBADepartmentQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAGroups()
        {
            return Ok(await this.mediator.Send(new GetEbaGroupsQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEBAUnits()
        {
            return Ok(await this.mediator.Send(new GetEbaUnitsQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAdPublisher()
        {
            return Ok(await this.mediator.Send(new GetAdPublisherQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAdQuesiton()
        {
            return Ok(await this.mediator.Send(new GetAdQuestionsQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAdstatus()
        {
            return Ok(await this.mediator.Send(new GetAdStatuesQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEbaLocaiton()
        {
            return Ok(await this.mediator.Send(new GetEbaLocationsQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEbaPosition()
        {
            return Ok(await this.mediator.Send(new GetEbaPositionQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllEducationLevel()
        {
            return Ok(await this.mediator.Send(new GetEducationLevelsQueryRequest()));
        }
        
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllExperincePeriod()
        {
            return Ok(await this.mediator.Send(new GetExperiencePeriodsQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllForignLanguage()
        {
            return Ok(await this.mediator.Send(new GetForignLanguagesQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetallJobCategory()
        {
            return Ok(await this.mediator.Send(new GetJobCategoriesQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllMillitaryStatus()
        {
            return Ok(await this.mediator.Send(new GetMillitaryStatusesQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllPositionsTypes()
        {
            return Ok(await this.mediator.Send(new GetPositionsQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllSkillAndExpertis()
        {
            return Ok(await this.mediator.Send(new GetSkillAndExpertisesQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllTaskType()
        {
            return Ok(await this.mediator.Send(new GetTasksTypesQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllWorkModel()
        {
            return Ok(await this.mediator.Send(new GetWorkModelsQueryRequest()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllWorkType()
        {
            return Ok(await this.mediator.Send(new GetWorkTypesQueryRequest()));
        }


    }
}
