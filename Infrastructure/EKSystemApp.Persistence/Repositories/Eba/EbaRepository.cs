using AutoMapper;
using Azure.Core;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Eba.TMP.OrganizationTree;
using EKSystemApp.Application.DTO.Member.CountriesTree;
using EKSystemApp.Application.DTO.Member.Education.UniversitiesTree;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.eBA;
using EKSystemApp.Domain.Entities.eBA.ForeignLanguages;
using EKSystemApp.Domain.Entities.eBA.GeneralSkills;
using EKSystemApp.Domain.Entities.Member.Countries;
using EKSystemApp.Domain.Entities.Member.Education.Universities;
using EKSystemApp.Persistence.Context;

namespace EKSystemApp.Persistence.Repositories.Eba
{
    public class EbaRepository : IEbaRepository
    {
        private readonly EbaDbContext _context;
        private readonly IMapper _mapper;

        public EbaRepository(EbaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ICollection<TmpZhrCalisanPersWsDto>> GetEmployeeDetails(int id)
        {
            var result = _context.TmpZhrCalisanPersWs.ToList();

            return _mapper.Map<List<TmpZhrCalisanPersWs>, List<TmpZhrCalisanPersWsDto>>(result);
        }

        public async Task<ICollection<TDto>> GetEbaItemsByUpObjId<TDto>(int parentId)
        {
            var holdingList = _context.TmpOrganizationTree
                .Where(t => t.OBJID != 0 && (t.UP_OBJID == parentId && t.UP_OBJID != 0))
                .ToList();

            var drList = _context.TmpOrganizationTreeDr
                .Where(t => t.OBJID != 0 && t.UP_OBJID == parentId && t.UP_OBJID != 0)
                .ToList();

            var holdingResult = _mapper.Map<ICollection<TmpOrganizationTree>, ICollection<TDto>>(holdingList);
            var drResult = _mapper.Map<ICollection<TmpOrganizationTreeDr>, ICollection<TDto>>(drList);

            var result = holdingResult.Union(drResult).ToList();

            return result;
        }

        public async Task<ICollection<EbaKvpDto>> GetEbaProfessionsByParameters(CheckEbaProfessionQueryRequest request) //get_Gorev
        {
            var holdingList = _context.TmpOrganizationTree.ToList();
            var drList = _context.TmpOrganizationTreeDr.ToList();

            var holdingResult = _mapper.Map<ICollection<TmpOrganizationTree>, ICollection<TmpOrganizationTreeDto>>(holdingList);
            var drResult = _mapper.Map<ICollection<TmpOrganizationTreeDr>, ICollection<TmpOrganizationTreeDto>>(drList);

            var combinedResultList = holdingResult.Union(drResult).ToList();

            string sorguId;

            if (!string.IsNullOrEmpty(request.OrgId) && !string.IsNullOrEmpty(request.GroupId) && !string.IsNullOrEmpty(request.DepartmentId) && !string.IsNullOrEmpty(request.UnitId))
            {
                sorguId = request.UnitId;
            }
            else if (!string.IsNullOrEmpty(request.OrgId) && !string.IsNullOrEmpty(request.GroupId) && !string.IsNullOrEmpty(request.DepartmentId))
            {
                sorguId = request.DepartmentId;
            }
            else if (!string.IsNullOrEmpty(request.OrgId) && !string.IsNullOrEmpty(request.GroupId))
            {
                sorguId = request.GroupId;
            }
            else
            {
                sorguId = request.OrgId;
            }

            var filteredList = combinedResultList
            .Where(x => x.UP_OBJID == Convert.ToInt32(sorguId) || (sorguId != request.OrgId && (x.UP_OBJID == Convert.ToInt32(sorguId) || x.OBJID == Convert.ToInt32(sorguId))))
            .Select(x=>x.POZISYON)
            .ToList();

            string positions = string.Join(", ", filteredList);

            var gorevList = (from z in _context.GorevlerFullSap
                             where positions.Contains(z.ID)
                             select z).OrderBy(x=>x.UNVAN_TANIM).ToList();

            var result = _mapper.Map<ICollection<GorevlerFullSap>, ICollection<EbaKvpDto>>(gorevList);

            return result;
        }

        public async Task<ICollection<EbaStrKvpDto>> GetEbaForeignLanguages()
        {
            var query = (from p in _context.P_Languages
                        join d in _context.P_LanguagesDataGrid on p.ID equals d.FORMID
                        join m in _context.M_Languages on d.DOCUMENTID equals m.ID
                        where m.ChkAktif == 1
                        select m).ToList();

            var result = _mapper.Map<ICollection<M_Languages>, ICollection<EbaStrKvpDto>>(query);

            return result;
        }

        public async Task<ICollection<EbaKvpDto>> GetEbaGeneralSkills()
        {
            var query = (from p in _context.P_Skills
                         join d in _context.P_SkillsDataGrid on p.ID equals d.FORMID
                         join m in _context.M_Skills on d.DOCUMENTID equals m.ID
                         where m.ChkAktif == 1
                         select m).ToList();

            var result = _mapper.Map<ICollection<M_Skills>, ICollection<EbaKvpDto>>(query);

            return result;
        }

        public async Task<EbaIseAlimTurkuvazFormDto> GetIseAlimTurkuvazFormDetailsByProcessId(CheckEbaIseAlimFormDetailsQueryRequest request)
        {
            int mainFormId = 0;
            int processId = 0;

            var formDetails = (from frm in _context.IseAlimForm
                               join fd in _context.FlowDocuments on frm.ID equals fd.FILEPROFILEID
                               join lf in _context.LiveFlows on fd.PROCESSID equals lf.ID
                               where lf.DELETED == 0 && lf.ID == request.ProcessId
                               select frm).FirstOrDefault();

            if (formDetails != null)
            {
                mainFormId = formDetails.ID;
                processId = request.ProcessId;

                var selectedSkills = (from skl in _context.IseAlimGeneralSkillsDataGrid
                                      where skl.FORMID == mainFormId
                                      select skl).ToList();

                var selectedLanguages = (from lan in _context.IseAlimForeignLanguagesDataGrid
                                         where lan.FORMID == mainFormId
                                         select lan).ToList();

                var mappedFormDetails = _mapper.Map<IseAlimForm, EbaIseAlimTurkuvazFormDto>(formDetails);
                //var mappedSkills = _mapper.Map<ICollection<IseAlimGeneralSkillsDataGrid>, ICollection<GeneralSkillsDto>>(selectedSkills);
                //var mappedLanguages = _mapper.Map<ICollection<IseAlimForeignLanguagesDataGrid>, ICollection<ForeignLanguagesDto>>(selectedLanguages);

                if (selectedSkills != null && selectedSkills.Any())
                {
                    var mappedSkills = _mapper.Map<ICollection<IseAlimGeneralSkillsDataGrid>, ICollection<GeneralSkillsDto>>(selectedSkills);
                    mappedFormDetails.GeneralSkills = mappedSkills.ToList();
                }
                
                if (selectedLanguages != null && selectedLanguages.Any())
                {
                    var mappedLanguages = _mapper.Map<ICollection<IseAlimForeignLanguagesDataGrid>, ICollection<ForeignLanguagesDto>>(selectedLanguages);
                    mappedFormDetails.ForeignLanguages = mappedLanguages.ToList();
                }

                mappedFormDetails.ProcessId = processId;

                return mappedFormDetails;
            }
            else
            {
                return new EbaIseAlimTurkuvazFormDto();
            }
            
        }

        public async Task<ICollection<OrganizationTreeDto>> GetOrganizationTreeById(string key)
        {
            var organizationList = _context.TmpZhrCalisanPersWs.ToList();

            var filteredOrganizationList = organizationList.DistinctBy(x => x.ZORG).Where(x => x.ZORG == key).OrderBy(x => x.ORGTX).ToList();

            var mappedOrganizationList = _mapper.Map<IEnumerable<TmpZhrCalisanPersWs>, ICollection<OrganizationTreeDto>>(filteredOrganizationList);

            if (mappedOrganizationList.Any())
            {
                foreach (var organization in mappedOrganizationList)
                {
                    organization.Groups = GetEbaItemsByUpObjId<GroupTreeDto>(Convert.ToInt32(organization.Key)).Result;

                    if (organization.Groups.Any())
                    {
                        foreach (var groups in organization.Groups)
                        {
                            groups.Departments = GetEbaItemsByUpObjId<DepartmentTreeDto>(Convert.ToInt32(groups.Key)).Result;

                            if (groups.Departments.Any())
                            {
                                foreach (var departments in groups.Departments)
                                {
                                    departments.Units = GetEbaItemsByUpObjId<UnitTreeDto>(Convert.ToInt32(departments.Key)).Result;
                                }
                            }
                        }
                    }
                }
            }

            return mappedOrganizationList;
        }

        public async Task<ICollection<CountryTreeDto>> GetCountryTreeById(int key)
        {
            var countryList = _context.ST_Countries.ToList();

            var filteredCountryList = countryList.Where(x => x.Key == key).OrderBy(x => x.Value).ToList();

            var mappedCountryList = _mapper.Map<ICollection<ST_Countries>, ICollection<CountryTreeDto>>(filteredCountryList);

            foreach (var country in mappedCountryList)
            {
                var provinceList = _context.ST_Provinces.Where(x => x.UpKey == key).ToList();
                var mappedProvinceList = _mapper.Map<ICollection<ProvinceTreeDto>>(provinceList);

                country.Provinces = mappedProvinceList;

                foreach (var province in country.Provinces)
                {
                    var cityList = _context.ST_Cities.Where(x => x.UpKey == province.Key).ToList();
                    var mappedCityList = _mapper.Map<ICollection<CityTreeDto>>(cityList);

                    province.Cities = mappedCityList;
                }
            }

            return mappedCountryList;
        }

        public async Task<ICollection<UniversityTreeDto>> GetUniversityTreeById(int key)
        {
            var universityList = _context.ST_Universities.ToList();

            var filteredUniversityList = universityList.Where(x => x.Key == key).OrderBy(x => x.Value).ToList();

            var mappedUniversityList = _mapper.Map<ICollection<ST_Universities>, ICollection<UniversityTreeDto>>(filteredUniversityList);

            foreach (var university in mappedUniversityList)
            {
                var departmentList = _context.ST_Departments.Where(x => x.UpKey == university.Key).ToList();
                var mappedDepartmentList = _mapper.Map<ICollection<EducationDepartmentTreeDto>>(departmentList);

                university.Departments = mappedDepartmentList;
            }

            return mappedUniversityList;
        }
    }
}
