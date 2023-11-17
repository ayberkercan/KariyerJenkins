﻿using AutoMapper;
using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Application.Features.Adverts.Commands.Create;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class CreateAdvertCommandHandler : IRequestHandler<NewAdvertCreateCommandRequest, CreateAdvertDto>
    {
        private readonly IGenericRepository<AdvertCreate> AdvertCreateRepository;
        private readonly IMapper mapper;
        private readonly IGenericRepository<MillitaryStatus> MillitaryStatusRepository;
        private readonly IGenericRepository<AdvertForignLanguages> ForignLanguageRepository;
        private readonly IGenericRepository<AdvertSkillAndExpertises> SkillAndExpertiseRepository;
        private readonly IGenericRepository<AdvertAdQuestions> AdQuestionRepository;

        public CreateAdvertCommandHandler(IGenericRepository<AdvertCreate> AdvertCreateRepository,
            IGenericRepository<MillitaryStatus> MillitaryStatusRepository,
            IGenericRepository<AdvertSkillAndExpertises> SkillAndExpertiseRepository,
            IGenericRepository<AdvertForignLanguages> ForignLanguageRepository,
             IGenericRepository<AdvertAdQuestions> AdQuestionRepository,
            IMapper mapper)
        {
            this.AdvertCreateRepository = AdvertCreateRepository;
            this.mapper = mapper;
            this.MillitaryStatusRepository = MillitaryStatusRepository;
            this.ForignLanguageRepository = ForignLanguageRepository;
            this.SkillAndExpertiseRepository = SkillAndExpertiseRepository;
            this.AdQuestionRepository = AdQuestionRepository;
        }

        public async Task<CreateAdvertDto> Handle(NewAdvertCreateCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await this.AdvertCreateRepository.CreateAsync(new AdvertCreate
            {
                WorkDefination = request.WorkDefination,
                PublicQuality = request.PublicQuality,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                AdvertNumberId = request.AdvertNumberId,
                PeriotNumberId = request.PeriotNumberId,
                PositionName = request.PositionName,
                Logo = request.Logo,
                TaskTypeName = request.TaskTypeName,
                CompanyName = request.CompanyName,
                OrganizationName = request.OrganizationName,
                GroupName = request.GroupName,
                DepartmentName = request.DepartmentName,
                UnitName = request.UnitName,
                WorkTypeName = request.WorkTypeName,
                PositionTypeName = request.PositionTypeName,
                WorkModelName = request.WorkModelName,
                LocationName = request.LocationName,
                EducationLevelName = request.EducationLevelName,
                ExperiencePeriod = request.ExperiencePeriodName,
                MillitaryStatusName = request.MillitaryStatusName,
                AdvertStatusName = request.AdvertStatusName,
                AdvertPublisherName = request.AdvertPublisherName,
                Brand = request.Brand,
                WorkCategory = request.WorkCategory,


            });

            var ForignLanguage = new AdvertForignLanguages();

            ForignLanguage.AdvertCreateId = data.Id;
            ForignLanguage.ForeignLanguageName = request.ForeignLanguageLevels;
            ForignLanguage.Id = Guid.NewGuid();
            ForignLanguage.ForeignLanguageName = request.ForeignLanguages.ToString()!.Replace("\"[", "[").Replace("]\"", "]").Replace("\\", ""); ;

            await ForignLanguageRepository.CreateAsync(ForignLanguage);

            var skillAndexpertise = new AdvertSkillAndExpertises();
            foreach (var item in request.SkillAndExpertises)
            {
                skillAndexpertise.AdvertCreateId = data.Id;
                skillAndexpertise.Id = Guid.NewGuid();
                skillAndexpertise.SkillAndExpertiseName = item.ToString();
                await SkillAndExpertiseRepository.CreateAsync(skillAndexpertise);
            };


            var adQuestions = new AdvertAdQuestions();
            foreach (var item in request.AdQuestions)
            {
                adQuestions.AdvertCreateId = data.Id;
                adQuestions.Id = Guid.NewGuid();
                adQuestions.AdQuestionName = item.ToString();
                await AdQuestionRepository.CreateAsync(adQuestions);
            };

            return this.mapper.Map<CreateAdvertDto>(data);
        }
    }
}
