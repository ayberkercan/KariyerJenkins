using EKSystemApp.Application.ElasticSearcServiceAndMapping.Services;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.Adwerts;
using EKSystemApp.Application.Interfaces.Common;
using EKSystemApp.Application.Interfaces.IElasticSearchService;
using EKSystemApp.Application.Interfaces.ILDAPAuthService;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Application.Tools;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.PermissonList;
using EKSystemApp.Persistence.Context;
using EKSystemApp.Persistence.DbInitializerService;
using EKSystemApp.Persistence.DbInitiliazers;
using EKSystemApp.Persistence.LDAPAuth;
using EKSystemApp.Persistence.Repositories;
using EKSystemApp.Persistence.Repositories.Adverts;
using EKSystemApp.Persistence.Repositories.Common;
using EKSystemApp.Persistence.Repositories.Eba;
using EKSystemApp.Persistence.Repositories.User;
using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json;
namespace EKSystemApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region DB
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });

            services.AddDbContext<EbaDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("eBA"));
            });
            #endregion

            #region JWT
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
                options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            });
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, opt =>
            {
                opt.RequireHttpsMetadata = false;
                opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidAudience = JwtTokenDefaults.ValidAudience,
                    ValidIssuer = JwtTokenDefaults.ValidIssuer,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                };
                opt.Events = new JwtBearerEvents
                {
                    OnTokenValidated = ctx => Task.CompletedTask,
                    OnAuthenticationFailed = ctx => Task.CompletedTask
                };
            });
            #endregion

            #region Policy
            services.AddAuthorization(options =>
            {
                options.AddPolicy("ProductPolicy", policy =>
                {
                    policy.RequireClaim("permission", Permissions.Product.Read);
                });
            });

            #endregion

            #region IOC
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IEbaGenericRepository<>), typeof(EbaGenericRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDbInitiliazerContext, DBInitiliazerContext>();
            services.AddScoped<IEbaRepository, EbaRepository>();
            services.AddScoped<ILDAPAuthService, LDAPAuthService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IFileConverterService, FileConverterService>();

            services.AddScoped<IAdvertQuestionsAndContent, AdvertQuestionsAndContentRepository>();
            services.AddScoped(typeof(IElasticSearchService<>), typeof(ElasticSearchService<>));
            #endregion

            //#region CORS 
            //services
            //    .AddCors(options => options.AddDefaultPolicy(policy => policy
            //    .WithOrigins(configuration.GetConnectionString("ClientCors")!, configuration.GetConnectionString("ClientCors")!)
            //    .AllowAnyHeader()
            //    .AllowAnyMethod()
            //    .AllowCredentials()
            // ));
            //#endregion
            services.AddAuthentication( CertificateAuthenticationDefaults.AuthenticationScheme).AddCertificate();
        }
        
    }
}