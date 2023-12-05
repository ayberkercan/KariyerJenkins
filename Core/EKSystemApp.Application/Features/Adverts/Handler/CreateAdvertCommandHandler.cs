using AutoMapper;
using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Application.Features.Adverts.Commands.Create;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.Common;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class CreateAdvertCommandHandler : IRequestHandler<NewAdvertCreateCommandRequest, CreateAdvertDto>
    {
        #region Repository
        private readonly IMapper mapper;
        private readonly IGenericRepository<AdvertCreate> AdvertCreateRepository;
        private readonly IGenericRepository<Brand> BrandRepository;
        private readonly IGenericRepository<Position> PositionRepository;
        private readonly IGenericRepository<Organization> OrganizationRepository;
        private readonly IGenericRepository<Group> GroupRepository;
        private readonly IGenericRepository<Department> DepartmentRepository;
        private readonly IGenericRepository<EKSystemApp.Domain.Entities.Admin.AdminBaseEntity.Unit> UnitRepository;
        private readonly IGenericRepository<WorkType> WorkTypeRepository;
        private readonly IGenericRepository<PositionType> PositionTypeRepository;
        private readonly IGenericRepository<WorkModel> WorkModelRepository;
        private readonly IGenericRepository<Location> LocationRepository;
        private readonly IGenericRepository<EducationLevel> EducationLevelRepository;
        private readonly IGenericRepository<MillitaryStatus> MillitaryStatusRepository;
        private readonly IGenericRepository<AdvertStatus> AdvertStatusRepository;
        private readonly IGenericRepository<AdvertSkillAndExpertises> AdvertSkillAndExpertisesRepository;
        private readonly IGenericRepository<AdvertForeignLanguages> AdvertForeignLanguagesRepository;
        private readonly IGenericRepository<AdvertAdQuestions> AdvertAdQuestionsRepository;
        private readonly IGenericRepository<WorkCategory> WorkCategoryRepository;
        private readonly IGenericRepository<ExperiencePeriod> ExperiencePeriodRepository;
        private readonly IGenericRepository<AdvertForeignLanguages> ForignLanguageRepository;
        private readonly IGenericRepository<AdvertSkillAndExpertises> SkillAndExpertiseRepository;
        private readonly IGenericRepository<AdvertAdQuestions> AdQuestionRepository;
        private readonly IGenericRepository<Logo> LogoRepository;
        #endregion
        public CreateAdvertCommandHandler(
        #region Const.
            IGenericRepository<AdvertCreate> advertCreateRepository,
            IGenericRepository<Brand> brandRepository,
            IGenericRepository<Position> positionRepository,
            IGenericRepository<Organization> organizationRepository,
            IGenericRepository<Department> departmentRepository,
            IGenericRepository<Domain.Entities.Admin.AdminBaseEntity.Unit> unitRepository,
            IGenericRepository<WorkType> workTypeRepository,
            IGenericRepository<PositionType> positionTypeRepository,
            IGenericRepository<WorkModel> workModelRepository,
            IGenericRepository<Location> locationRepository,
            IGenericRepository<EducationLevel> educationLevelRepository,
            IGenericRepository<MillitaryStatus> millitaryStatusRepository,
            IGenericRepository<AdvertStatus> advertStatusRepository,
            IGenericRepository<AdvertSkillAndExpertises> advertSkillAndExpertisesRepository,
            IGenericRepository<AdvertForeignLanguages> advertForeignLanguagesRepository,
            IGenericRepository<AdvertAdQuestions> advertAdQuestionsRepository,
            IGenericRepository<WorkCategory> workCategoryRepository,
            IGenericRepository<ExperiencePeriod> experiencePeriodRepository,
            IMapper mapper,
            IGenericRepository<AdvertForeignLanguages> forignLanguageRepository,
            IGenericRepository<AdvertSkillAndExpertises> skillAndExpertiseRepository,
            IGenericRepository<AdvertAdQuestions> adQuestionRepository,
            IGenericRepository<Group> groupRepository
,
            IGenericRepository<Logo> logoRepository
,
            IFileService fileService

        #endregion
            )
        {
            #region Const. -2
            AdvertCreateRepository = advertCreateRepository;
            BrandRepository = brandRepository;
            PositionRepository = positionRepository;
            OrganizationRepository = organizationRepository;
            DepartmentRepository = departmentRepository;
            UnitRepository = unitRepository;
            WorkTypeRepository = workTypeRepository;
            PositionTypeRepository = positionTypeRepository;
            WorkModelRepository = workModelRepository;
            LocationRepository = locationRepository;
            EducationLevelRepository = educationLevelRepository;
            MillitaryStatusRepository = millitaryStatusRepository;
            AdvertStatusRepository = advertStatusRepository;
            AdvertSkillAndExpertisesRepository = advertSkillAndExpertisesRepository;
            AdvertForeignLanguagesRepository = advertForeignLanguagesRepository;
            AdvertAdQuestionsRepository = advertAdQuestionsRepository;
            WorkCategoryRepository = workCategoryRepository;
            ExperiencePeriodRepository = experiencePeriodRepository;
            this.mapper = mapper;
            ForignLanguageRepository = forignLanguageRepository;
            SkillAndExpertiseRepository = skillAndExpertiseRepository;
            AdQuestionRepository = adQuestionRepository;
            GroupRepository = groupRepository;
            LogoRepository = logoRepository;
            #endregion

        }
        public async Task<CreateAdvertDto> Handle(NewAdvertCreateCommandRequest request, CancellationToken cancellationToken)
        {
            #region Create Advert
            var newAdvert = await this.AdvertCreateRepository
             .CreateAsync(
             new AdvertCreate
             {
                 AppUserId = request.AppUserId,
                 WorkDefination = request.WorkDefination,
                 PublicQuality = request.PublicQuality,
                 StartDate = request.StartDate,
                 EndDate = request.EndDate,
                 PeriotNumberId = request.PeriotNumberId,
                 AdvertNumberId = request.AdvertNumberId,
                 AdvertPublisherName = request.AdvertPublisherName,
                 EbaProcessId = request.PeriotNumberId.ToString(),
                 ProcessNumber = request.PeriotNumberId.ToString()
             });
            #endregion

            #region List Added

            var newBrand = await this.BrandRepository
                .CreateAsync(
                new Brand
                {
                    AdvertCreateId = newAdvert.Id,
                    BrandName = request.Brands
                });
            var newPosition = await this.PositionRepository
                .CreateAsync(
                new Position
                {
                    AdvertCreateId = newAdvert.Id,
                    PositionName = request.Positions,

                });
            var newOrganization = await this.OrganizationRepository
                .CreateAsync(
                new Organization
                {
                    AdvertCreateId = newAdvert.Id,
                    OrganizationName = request.Organizations,

                });
            var newGroup = await this.GroupRepository
                .CreateAsync(
                new Group
                {
                    AdvertCreateId = newAdvert.Id,
                    GroupName = request.Groups,

                });
            var newDepartment = await this.DepartmentRepository
                .CreateAsync(
                new Department
                {
                    AdvertCreateId = newAdvert.Id,
                    DepartmentName = request.Departments
                });
            var newUnit = await this.UnitRepository
                .CreateAsync(
                new Domain.Entities.Admin.AdminBaseEntity.Unit
                {
                    AdvertCreateId = newAdvert.Id,
                    UnitName = request.Units,
                });
            var newWorkType = await this.WorkTypeRepository
                .CreateAsync(
                new WorkType
                {
                    AdvertCreateId = newAdvert.Id,
                    WorkTypeName = request.WorkTypes,
                });
            var newPositionTypes = await this.PositionTypeRepository
                .CreateAsync(
                new PositionType
                {
                    AdvertCreateId = newAdvert.Id,
                    PositionTypeName = request.PositionTypes,
                });
            var newWorkModel = await this.WorkModelRepository
                .CreateAsync(
                new WorkModel
                {
                    AdvertCreateId = newAdvert.Id,
                    WorkModelName = request.WorkModels,
                });
            var newLocation = await this.LocationRepository
                .CreateAsync(
                new Location
                {
                    AdvertCreateId = newAdvert.Id,
                    LocationName = request.Locations,
                });
            var newEducationLevel = await this.EducationLevelRepository
                .CreateAsync(
                new EducationLevel
                {
                    AdvertCreateId = newAdvert.Id,
                    EducationLevelName = request.EducationLevels,
                });
            var newMillitaryStatus = await this.MillitaryStatusRepository
                .CreateAsync(
                new MillitaryStatus
                {
                    AdvertCreateId = newAdvert.Id,
                    MillitaryStatusName = request.MillitaryStatuses,
                });
            var newAdvertStatus = await this.AdvertStatusRepository
                .CreateAsync(
                new AdvertStatus
                {
                    AdvertCreateId = newAdvert.Id,
                    AdvertStatusName = request.AdvertStatuses,
                });
            foreach (var item in request.AdvertSkillAndExpertises)
            {
                var newAdvertSkillAndExpertises = await this.AdvertSkillAndExpertisesRepository
              .CreateAsync(
              new AdvertSkillAndExpertises
              {
                  AdvertCreateId = newAdvert.Id,
                  SkillAndExpertiseName = item.SkillAndExpertiseName,
              });
            }
            foreach (var item in request.AdvertForeignLanguages)
            {
                var newAdvertForeignLanguages = await this.AdvertForeignLanguagesRepository
                .CreateAsync(
                new AdvertForeignLanguages
                {
                    AdvertCreateId = newAdvert.Id,
                    ForeignLanguageName = item.ForeignLanguageName,
                    ForeignLanguageLevels = item.ForeignLanguageLevels
                });
            }
            foreach (var item in request.AdvertAdQuestions)
            {
                var newAdvertAdQuestions = await this.AdvertAdQuestionsRepository
               .CreateAsync(
               new AdvertAdQuestions
               {
                   AdvertCreateId = newAdvert.Id,
                   AdQuestionName = item.AdQuestionName,
               });
            }
            var newWorkCategory = await this.WorkCategoryRepository
               .CreateAsync(
                new WorkCategory
                {
                    AdvertCreateId = newAdvert.Id,
                    WorkCategoryName = request.WorkCategories,
                });
            var newExperiencePeriod = await this.ExperiencePeriodRepository
                .CreateAsync(
                new ExperiencePeriod
                {
                    AdvertCreateId = newAdvert.Id,
                    ExperiencePeriodName = request.ExperiencePeriods,
                });

            #endregion
            return this.mapper.Map<CreateAdvertDto>(newAdvert);
        }

    }
}
