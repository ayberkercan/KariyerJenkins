using System.Linq.Expressions;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Nest;

namespace EKSystemApp.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<T?> CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }
        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }
        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public async Task Remove(T entitiy)
        {
            _context.Set<T>().Remove(entitiy);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task asd(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<AdvertListDto>> GetAllAdverts()
        {
            List<AdvertListDto> list = new List<AdvertListDto>();
            var query = await _context.AdvertCreates
                    .Include(x => x.AdvertAdQuestions)
                    .Include(x => x.AdvertForeignLanguages)
                    .Include(x => x.AdvertSkillAndExpertises)
                    .Include(x => x.Brands)
                    .Include(x => x.Logos)
                    .Include(x => x.Organizations)
                    .Include(x => x.Groups)
                    .Include(x => x.Departments)
                    .Include(x => x.Units)
                    .Include(x => x.WorkTypes)
                    .Include(x => x.PositionTypes)
                    .Include(x => x.WorkModels)
                    .Include(x => x.Locations)
                    .Include(x => x.EducationLevels)
                    .Include(x => x.MillitaryStatuses)
                    .Include(x => x.AdvertStatuses)
                    .Include(x => x.WorkCategories)
                    .Include(x => x.Positions)
                    .Include(x => x.ExperiencePeriods)
                 
                   .Select(p => new
                   {
                       AdvertAdQuestions = p.AdvertAdQuestions,
                       AdvertForeignLanguages = p.AdvertForeignLanguages,
                       AdvertSkillAndExpertises = p.AdvertSkillAndExpertises,
                       AdvertPublisherName = p.AdvertPublisherName,
                       Brands = p.Brands,
                       Logos = p.Logos,
                       Organizations = p.Organizations,
                       Groups = p.Groups,
                       Departments = p.Departments,
                       Units = p.Units,
                       WorkTypes = p.WorkTypes,
                       PositionTypes = p.PositionTypes,
                       WorkModels = p.WorkModels,
                       Locations = p.Locations,
                       EducationLevels = p.EducationLevels,
                       MillitaryStatuses = p.MillitaryStatuses,
                       AdvertStatuses = p.AdvertStatuses,
                       WorkCategories = p.WorkCategories,
                       Positions = p.Positions,
                       ExperiencePeriods = p.ExperiencePeriods,
                       WorkDefination = p.WorkDefination,
                       StartDAte = p.StartDate,
                       EndDate = p.EndDate,
                       PublicQuality = p.PublicQuality,
                       PeriotNumberId = p.PeriotNumberId,
                       AdvertNumberId = p.AdvertNumberId,
                       EbaProcessId = p.EbaProcessId,
                      
                   }).AsNoTracking().ToListAsync();
            var k =  query.Select(p => new
            {
                AdvertAdQuestions = p.AdvertAdQuestions.ToList(),
                AdvertForeignLanguages = p.AdvertForeignLanguages.ToList(),
                AdvertSkillAndExpertises = p.AdvertSkillAndExpertises.Select(p => p.SkillAndExpertiseName).ToList(),
                Brands = p.Brands.Select(p => p.BrandName).FirstOrDefault(),
                Organizations = p.Organizations.Select(p => p.OrganizationName).FirstOrDefault(),
                Groups = p.Groups.Select(p => p.GroupName).FirstOrDefault(),
                Departments = p.Departments.Select(p => p.DepartmentName).FirstOrDefault(),
                Units = p.Units.Select(p => p.UnitName).FirstOrDefault(),
                WorkTypes = p.WorkTypes.Select(p => p.WorkTypeName ).FirstOrDefault(),
                PositionTypes = p.PositionTypes.Select(p => p.PositionTypeName).FirstOrDefault(),
                WorkModels = p.WorkModels.Select(p => p.WorkModelName).FirstOrDefault(),
                Locations = p.Locations.Select(p => p.LocationName).FirstOrDefault(),
                EducationLevels = p.EducationLevels.Select(p => p.EducationLevelName).FirstOrDefault(),
                MillitaryStatuses = p.MillitaryStatuses.Select(p => p.MillitaryStatusName).FirstOrDefault(),
                AdvertStatuses = p.AdvertStatuses.Select(p => p.AdvertStatusName).FirstOrDefault(),
                WorkCategories = p.WorkCategories.Select(p => p.WorkCategoryName).FirstOrDefault(),
                PositionKey = p.Positions.Select(p => p.PositionKey).FirstOrDefault(),
                PositionValue = p.Positions.Select(p => p.PositionName).FirstOrDefault(),
                ExperiencePeriods = p.ExperiencePeriods.Select(p => p.ExperiencePeriodName).FirstOrDefault(),
                WorkDefination = p.WorkDefination,
                StartDate = p.StartDAte,
                EndDate = p.EndDate,
                PublicQuality = p.PublicQuality,
                PeriotNumberId = p.PeriotNumberId,
                AdvertNumberId = p.AdvertNumberId,
                EbaProcessId = p.EbaProcessId,
                AdvertPublisherName = p.AdvertPublisherName,
                AppUserId = p.AppUserId,

            });
            foreach (var item in k)
            {
                var advert = new AdvertListDto
                {
                    WorkDefination = item.WorkDefination,
                    StartDate = Convert.ToDateTime(item.StartDate),
                    EndDate = item.EndDate,
                    AdvertStatusName = item.AdvertStatuses,
                    Brand = item.Brands.ToString(),
                    PublicQuality = item.PublicQuality,
                    PositionValue = item.PositionValue.ToString(),
                    //PositionKey = item.PositionKey.ToString(),
                    PeriotNumberId = item.PeriotNumberId.ToString(),
                    AdvertNumberId = item.AdvertNumberId.ToString(),
                    OrganizationName = item.Organizations.ToString(),
                    ExperiencePeriod = item.ExperiencePeriods.ToString(),
                    GroupName = item.Groups.ToString(),
                    DepartmentName = item.Departments.ToString(),
                    UnitName = item.Units.ToString(),
                    WorkTypeName = item.WorkTypes.ToString(),
                    PositionTypeName = item.PositionTypes.ToString(),
                    WorkModelName = item.WorkModels.ToString(),
                    EducationLevelName = item.EducationLevels.ToString(),
                    EbaProcessId = item.EbaProcessId,
                    AdvertForeignLanguages = item.AdvertForeignLanguages.ToList(),
                    AdvertAdQuestions = item.AdvertAdQuestions.ToList(),
                    AdvertSkillAndExpertises = item.AdvertSkillAndExpertises.ToList(),
                    AdvertPublisherName = item.AdvertPublisherName.ToString(),
                    LocationName = item.Locations.ToString(),
                    MillitaryStatusName = item.MillitaryStatuses.ToString(),
                    WorkCategory = item.WorkCategories.ToString(),
                };
                list.Add(advert);
            }
         
            
            return list;
        }
    }
}
