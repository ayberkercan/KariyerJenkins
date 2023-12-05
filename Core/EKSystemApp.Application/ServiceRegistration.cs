using System.Reflection;
using AutoMapper;
using EKSystemApp.Application.ElasticSearcServiceAndMapping.Mapping;
using EKSystemApp.Application.Mappings.AdPublisherMap;
using EKSystemApp.Application.Mappings.AdQuestionMap;
using EKSystemApp.Application.Mappings.AdStatusMap;
using EKSystemApp.Application.Mappings.AdvertMap;
using EKSystemApp.Application.Mappings.AppRoleMAp;
using EKSystemApp.Application.Mappings.AppUserMap;
using EKSystemApp.Application.Mappings.CategoriesProfileMap;
using EKSystemApp.Application.Mappings.CompanyMap;
using EKSystemApp.Application.Mappings.Eba;
using EKSystemApp.Application.Mappings.Eba.EBACompanyMap;
using EKSystemApp.Application.Mappings.Eba.EbaDepartmentMap;
using EKSystemApp.Application.Mappings.Eba.EbaGroupMap;
using EKSystemApp.Application.Mappings.Eba.EbaLocationMap;
using EKSystemApp.Application.Mappings.Eba.EbaOrganizationMap;
using EKSystemApp.Application.Mappings.Eba.EbaPositionMap;
using EKSystemApp.Application.Mappings.Eba.EbaUnitMap;
using EKSystemApp.Application.Mappings.EducationLevelMap;
using EKSystemApp.Application.Mappings.ExperiencePeriodMap;
using EKSystemApp.Application.Mappings.FileMap;
using EKSystemApp.Application.Mappings.ForignLanguagesMap;
using EKSystemApp.Application.Mappings.JobCategoriesMap;
using EKSystemApp.Application.Mappings.MailMessageMap;
using EKSystemApp.Application.Mappings.Member.ApplicationSourceMap;
using EKSystemApp.Application.Mappings.Member.CityMap;
using EKSystemApp.Application.Mappings.Member.CompanyMap;
using EKSystemApp.Application.Mappings.Member.CountryAreaCodeMap;
using EKSystemApp.Application.Mappings.Member.CountryMap;
using EKSystemApp.Application.Mappings.Member.CurrencyMap;
using EKSystemApp.Application.Mappings.Member.Education.DepartmentMap;
using EKSystemApp.Application.Mappings.Member.Education.UniversityMap;
using EKSystemApp.Application.Mappings.Member.ProvinceMap;
using EKSystemApp.Application.Mappings.Member.SalaryTypeMap;
using EKSystemApp.Application.Mappings.MenuMap;
using EKSystemApp.Application.Mappings.MillitaryStatusesMap;
using EKSystemApp.Application.Mappings.PositionsTypes;
using EKSystemApp.Application.Mappings.Products;
using EKSystemApp.Application.Mappings.SkillAndExpertisesMap;
using EKSystemApp.Application.Mappings.TasksTypes;
using EKSystemApp.Application.Mappings.UIMap;
using EKSystemApp.Application.Mappings.WorkModelMap;
using EKSystemApp.Application.Mappings.WorkTypeMap;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace EKSystemApp.Application
{
    public static class ServiceRegistration
    {
        #region Auto Mapper
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(opt =>
            {
                opt.AddProfiles(new List<Profile>
                {
                    new CategoryProfile(),
                    new ProductProfile(),
                    new AppUserProfile(),
                    new AppRoleProfile(),
                    new AppUserCompanyProfile(),
                    new MenuProfile(),
                    new PositionTypeProfile(),
                    new TaskTypeProfile(),
                    new EBACompanyProfile(),
                    new EbaUnitProfile(),
                    new EbaGroupProfile(),
                    new EbaDepartmentProfile(),
                    new EbaPositionProfile(),
                    new AdPublisherProfile(),
                    new MenuProfile(),
                    new PositionTypeProfile(),
                    new TaskTypeProfile(),
                    new AdQuestionProfile(),
                    new AdStatusProfile(),
                    new EducationLevelProfile(),
                    new JobCategoriesProfile(),
                    new MillitaryStatusesProfile(),
                    new PositionTypeProfile(),
                    new TaskTypeProfile(),
                    new WorkModelProfile(),
                    new WorkTypeProfile(),
                    new EbaOrganizationProfile(),
                    new EbaLocationProfile(),
                    new ExperiencePeriodProfile(),
                    new AdStatusProfile(),
                    new AdvertProfile(),
                    new EbaProfile(),
                    new CountryProfile(),
                    new ProvinceProfile(),
                    new CityProfile(),
                    new UniversityProfile(),
                    new DepartmentProfile(),
                    new AdQuestionProfile(),
                    new ForignLanguagesProfile(),
                    new SkillAndExpertisesProfile(),
                    new TurkuvazCompanyProfile(),
                    new CountryAreaCodeProfile(),
                    new SalaryTypeProfile(),
                    new CurrencyProfile(),
                    new ApplicationSourceProfile(),
                    new SavedFilterProfile(),
                    new MailMessageProfile(),
                    new FileProfile()
                });
            });
        }
        #endregion
    }
}
