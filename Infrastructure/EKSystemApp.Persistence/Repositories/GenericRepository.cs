using System.Linq.Expressions;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;

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
                var query = _context.AdvertCreates
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
                    .Include(x=>x.Positions)
                    .Include(x => x.ExperiencePeriods)
                    .AsNoTracking()
                    .ToList();
                List<AdvertListDto> list = new List<AdvertListDto>();
            var result = query.Select(p =>
            (
                p.Id,
                p.WorkDefination,
                p.StartDate,
                p.EndDate,
                p.AdvertStatuses.Select(x=>x.AdvertStatusName),
                p.Brands.Select(x=>x.BrandName),
                p.PublicQuality,
                p.Positions.Select(x=>x.PositionName),
                p.PeriotNumberId,
                p.AdvertNumberId,
                p.Organizations.Select(x=>x.OrganizationName),
                p.Groups.Select(x=>x.GroupName),
                p.Departments.Select(x=>x.DepartmentName),
                p.Units.Select(x => x.UnitName),
                p.WorkTypes.Select(x => x.WorkTypeName),
                p.PositionTypes.Select(x => x.PositionTypeName),
                p.WorkModels.Select(x => x.WorkModelName),
                p.EducationLevels.Select(x => x.EducationLevelName)
            ));
            foreach (var item in result)
            {
                var advert = new AdvertListDto
                {
                    Id = item.Id,
                    WorkDefination = item.WorkDefination,
                    StartDate = Convert.ToDateTime(item.StartDate),
                    EndDate = Convert.ToDateTime(item.EndDate),
                    AdvertStatusName = item.Item5.ToString(),
                    Brand = item.Item6.ToString(),
                    PublicQuality = item.PublicQuality,
                    PositionName = item.Item8.ToString(),
                    PeriotNumberId = item.PeriotNumberId.ToString(),
                    AdvertNumberId = item.AdvertNumberId.ToString(),
                    OrganizationName = item.Item11.ToString(),
                    GroupName = item.Item12.ToString(),
                    DepartmentName = item.Item13.ToString(),
                    UnitName = item.Item14.ToString(),
                    WorkTypeName = item.Item15.ToString(),
                    PositionTypeName = item.Item16.ToString(),
                    WorkModelName = item.Item17.ToString(),
                    EducationLevelName = item.Item18.ToString(),
                };
                list.Add(advert);
            }
            return list;
        }
    }
}
