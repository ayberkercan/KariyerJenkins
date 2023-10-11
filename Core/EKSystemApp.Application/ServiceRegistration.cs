using System.Reflection;
using AutoMapper;
using EKSystemApp.Application.Mappings.AppRoleMAp;
using EKSystemApp.Application.Mappings.AppUserMap;
using EKSystemApp.Application.Mappings.CategoriesProfileMap;
using EKSystemApp.Application.Mappings.CompanyMap;
using EKSystemApp.Application.Mappings.EBACompanyMap;
using EKSystemApp.Application.Mappings.MenuMap;
using EKSystemApp.Application.Mappings.PositionsTypes;
using EKSystemApp.Application.Mappings.Products;
using EKSystemApp.Application.Mappings.TasksTypes;
using EKSystemApp.Domain.Entities;
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
                    new EBACompanyProfile()
                    
                });
            });
        }
        #endregion
    }
}
