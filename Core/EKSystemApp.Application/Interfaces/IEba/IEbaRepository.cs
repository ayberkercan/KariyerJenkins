using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Eba.TMP.OrganizationTree;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.DTO.Member.Education.UniversitiesTree;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;

namespace EKSystemApp.Application.Interfaces.IUser
{
    public interface IEbaRepository
    {
        Task<ICollection<TmpZhrCalisanPersWsDto>> GetEmployeeDetails(int id);
        Task<ICollection<TDto>> GetEbaItemsByUpObjId<TDto>(int parentId);
        Task<ICollection<EbaKvpDto>> GetEbaProfessionsByParameters(CheckEbaProfessionQueryRequest request);
        Task<ICollection<EbaStrKvpDto>> GetEbaForeignLanguages();
        Task<ICollection<EbaKvpDto>> GetEbaGeneralSkills();
        Task<EbaIseAlimTurkuvazFormDto> GetIseAlimTurkuvazFormDetailsByProcessId(CheckEbaIseAlimFormDetailsQueryRequest request);
        Task<ICollection<OrganizationTreeDto>> GetOrganizationTreeById(string key);
        Task<ICollection<CountryTreeDto>> GetCountryTreeById(string key);
        Task<ICollection<UniversityTreeDto>> GetUniversityTreeById(int key);
        Task<ICollection<EbaStrKvpDto>> GetEbaEducationDepartments();
        Task<ICollection<EbaStrKvpDto>> GetEbaSelectableCompanies();
        Task<ICollection<EbaStrKvpDto>> GetEbaApplicationSources();
        Task<ICollection<AdvertListDto>> GetEbaEmployeeRequestForms(ICollection<AdvertListDto> advertCreates);
    }
}
