using AutoMapper;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Application.Features.EBA.TMP.Queries;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.eBA;
using EKSystemApp.Domain.Entities.eBA.ForeignLanguages;
using EKSystemApp.Domain.Entities.eBA.GeneralSkills;
using EKSystemApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Nest;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Nest.JoinField;

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

            if (!string.IsNullOrEmpty(request.orgId) && !string.IsNullOrEmpty(request.groupId) && !string.IsNullOrEmpty(request.departmentId) && !string.IsNullOrEmpty(request.unitId))
            {
                sorguId = request.unitId;
            }
            else if (!string.IsNullOrEmpty(request.orgId) && !string.IsNullOrEmpty(request.groupId) && !string.IsNullOrEmpty(request.departmentId))
            {
                sorguId = request.departmentId;
            }
            else if (!string.IsNullOrEmpty(request.orgId) && !string.IsNullOrEmpty(request.groupId))
            {
                sorguId = request.groupId;
            }
            else
            {
                sorguId = request.orgId;
            }

            var filteredList = combinedResultList
            .Where(x => x.UP_OBJID == Convert.ToInt32(sorguId) || (sorguId != request.orgId && (x.UP_OBJID == Convert.ToInt32(sorguId) || x.OBJID == Convert.ToInt32(sorguId))))
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
                               where lf.DELETED == 0 && lf.ID == request.processId
                               select frm).FirstOrDefault();

            if (formDetails != null)
            {
                mainFormId = formDetails.ID;
                processId = request.processId;

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
    }
}
