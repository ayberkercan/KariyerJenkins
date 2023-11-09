using AutoMapper;
using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Application.Features.Adverts.Commands.Create;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.Eba;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class CreateAdvertCommandHandler : IRequestHandler<NewAdvertCreateCommandRequest, CreateAdvertDto>
    {
        private readonly IGenericRepository<AdvertCreate> AdvertCreateRepository;
        private readonly IMapper mapper;
        private readonly IGenericRepository<Position> PositionRepository;
        private readonly IGenericRepository<TaskType> TaskTypeRepository;
        private readonly IGenericRepository<EbaCompany>  CompanyRepository;
        private readonly IGenericRepository<Organization> OrganizationRepository;
        private readonly IGenericRepository<EbaGroup> EbaGroupRepository;
        private readonly IGenericRepository<EbaDepartment> EbaDepartmentRepository;
        private readonly IGenericRepository<EbaUnit> EbaUnitRepository;
        private readonly IGenericRepository<WorkType> WorkTypeRepository;
        private readonly IGenericRepository<PositionType> PositionTypeRepository;
        private readonly IGenericRepository<WorkModel> WorkModelRepository;
        private readonly IGenericRepository<Location> LocationRepository;
        private readonly IGenericRepository<EducationLevel> EducationLevelRepository;
        private readonly IGenericRepository<ExperiencePeriod> ExperiencePeriodRepository;
        private readonly IGenericRepository<MillitaryStatus> MillitaryStatusRepository;
        private readonly IGenericRepository<ForignLanguage> ForignLanguageRepository;
        private readonly IGenericRepository<SkillAndExpertise> SkillAndExpertiseRepository;
        private readonly IGenericRepository<JobCategory> JobCategoryRepository;
        private readonly IGenericRepository<AdStatus> AdStatusRepository;
        private readonly IGenericRepository<AdPublisher> AdPublisherRepository;
        private readonly IGenericRepository<AdQuestion> AdQuestionRepository;

        public CreateAdvertCommandHandler(IGenericRepository<AdvertCreate> AdvertCreateRepository,
            IGenericRepository<Position> PositionRepository,
            IGenericRepository<TaskType> TaskTypeRepository,
            IGenericRepository<EbaCompany> CompanyRepository,
            IGenericRepository<Organization> OrganizationRepository,
            IGenericRepository<EbaGroup> EbaGroupRepository,
            IGenericRepository<EbaDepartment> EbaDepartmentRepository,
            IGenericRepository<EbaUnit> EbaUnitRepository,
            IGenericRepository<WorkType> WorkTypeRepository,
            IGenericRepository<PositionType> PositionTypeRepository,
            IGenericRepository<WorkModel> WorkModelRepository,
            IGenericRepository<Location> LocationRepository,
            IGenericRepository<EducationLevel> EducationLevelRepository,
            IGenericRepository<ExperiencePeriod> ExperiencePeriodRepository,
            IGenericRepository<MillitaryStatus> MillitaryStatusRepository,
            IGenericRepository<SkillAndExpertise> SkillAndExpertiseRepository,
            IGenericRepository<JobCategory> JobCategoryRepository,
            IGenericRepository<AdStatus> AdStatusRepository,
            IGenericRepository<AdPublisher> AdPublisherRepository,
            IGenericRepository<AdQuestion> AdQuestionRepository,
            IGenericRepository<ForignLanguage> ForignLanguageRepository,
            IMapper mapper)
        {
            this.AdvertCreateRepository = AdvertCreateRepository;
            this.mapper = mapper;
            this.PositionRepository = PositionRepository;
            this.TaskTypeRepository = TaskTypeRepository;
            this.AdPublisherRepository = AdPublisherRepository;
            this.AdQuestionRepository = AdQuestionRepository;
            this.AdStatusRepository = AdStatusRepository;
            this.JobCategoryRepository = JobCategoryRepository;
            this.CompanyRepository = CompanyRepository;
            this.OrganizationRepository = OrganizationRepository;
            this.EbaGroupRepository = EbaGroupRepository;
            this.EbaDepartmentRepository = EbaDepartmentRepository;
            this.EbaUnitRepository = EbaUnitRepository;
            this.WorkModelRepository = WorkModelRepository;
            this.WorkTypeRepository = WorkTypeRepository;
            this.PositionTypeRepository = PositionTypeRepository;
            this.LocationRepository = LocationRepository;
            this.EducationLevelRepository = EducationLevelRepository;
            this.ExperiencePeriodRepository = ExperiencePeriodRepository;
            this.MillitaryStatusRepository = MillitaryStatusRepository;
            this.ForignLanguageRepository = ForignLanguageRepository;
            this.SkillAndExpertiseRepository = SkillAndExpertiseRepository;
        }

        public async Task<CreateAdvertDto> Handle(NewAdvertCreateCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await this.AdvertCreateRepository.CreateAsync(new AdvertCreate
            {
                WorkDefination = request.WorkDefination,
                PublicQuality = request.PublicQuality,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                AdwertNumberId = request.AdwertNumberId,
                PeriotNumberId = request.PeriotNumberId,
            });

            var positions = new Position
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                PositionName =  request.PositionName
            };
            await PositionRepository.CreateAsync(positions);

            var taskType = new TaskType
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                TaskName = request.TaskTypeName
            };
            await TaskTypeRepository.CreateAsync(taskType);

            var adPublisher = new AdPublisher
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                AdPublisherName = request.AdPublisherName
            };
            await AdPublisherRepository.CreateAsync(adPublisher);

            var AdStatus = new AdStatus
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                AdStatusName = request.AdStatusName
            };
            await AdStatusRepository.CreateAsync(AdStatus);

            var jobCategory = new JobCategory
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                JobCategoryName = request.JobCategoryName
            };
            await JobCategoryRepository.CreateAsync(jobCategory);

            var ebaCompany = new EbaCompany
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                CompanyName = request.CompanyName
            };
            await CompanyRepository.CreateAsync(ebaCompany);

            var organization = new Organization
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                OrganizationName = request.OrganizationName
            };
            await OrganizationRepository.CreateAsync(organization);

            var group = new EbaGroup
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                GroupName = request.GroupName
            };
            await EbaGroupRepository.CreateAsync(group);

            var department = new EbaDepartment
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                DepartmentName = request.DepartmentName
            };
            await EbaDepartmentRepository.CreateAsync(department);

            var unit = new EbaUnit
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                UnitName = request.UnitName
            };
            await EbaUnitRepository.CreateAsync(unit);


            var workModel = new WorkModel
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                WorkModelName = request.WorkModelName
            };
            await WorkModelRepository.CreateAsync(workModel);

            var workType = new WorkType
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                WorkTypeName = request.WorkTypeName
            };
            await WorkTypeRepository.CreateAsync(workType);


            var positionType = new PositionType
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                PositionTypeName = request.PositionTypeName
            };
            await PositionTypeRepository.CreateAsync(positionType);

            var location = new Location
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                LocationName = request.LocationName
            };
            await LocationRepository.CreateAsync(location);


            var educationLevel = new EducationLevel
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                EducationLevelName = request.EducationLevelName
            };
            await EducationLevelRepository.CreateAsync(educationLevel);

            var experiencePeriod = new ExperiencePeriod
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                ExperiencePeriodName = request.ExperiencePeriodName
            };
            await ExperiencePeriodRepository.CreateAsync(experiencePeriod);

            var millitaryStatus = new MillitaryStatus
            {
                AdvertCreateId = data.Id,
                Id = Guid.NewGuid(),
                MillitaryStatusName = request.MillitaryStatusName
            };
            await MillitaryStatusRepository.CreateAsync(millitaryStatus);

            var ForignLanguage = new ForignLanguage();
            foreach (var item in request.ForignLanguageName)
            {
                ForignLanguage.AdvertCreateId = data.Id;
                ForignLanguage.Id = Guid.NewGuid();
                ForignLanguage.ForignLanguageName = item.ToString()!;
            };
            await ForignLanguageRepository.CreateAsync(ForignLanguage);

            var skillAndexpertise = new SkillAndExpertise();
            foreach (var item in request.SkillAndExpertiseName)
            {
                skillAndexpertise.AdvertCreateId = data.Id;
                skillAndexpertise.Id = Guid.NewGuid();
                skillAndexpertise.SkillAndExpertiseName = item.ToString()!;
            };
            await SkillAndExpertiseRepository.CreateAsync(skillAndexpertise);

            var adQuestions = new AdQuestion();
            foreach (var item in request.AdQuestionName)
            {
                adQuestions.AdvertCreateId = data.Id;
                adQuestions.Id = Guid.NewGuid();
                adQuestions.AdQuestionName = item.ToString()!;
            };
            await AdQuestionRepository.CreateAsync(adQuestions);

            return this.mapper.Map<CreateAdvertDto>(data);
        }
    }
}
