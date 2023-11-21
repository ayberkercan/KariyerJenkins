using AutoMapper;
using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Application.DTO.UI.SavedFilters.List;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Domain.Entities.UI.SavedFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.UIMap
{
    public class SavedFilterProfile : Profile
    {
        public SavedFilterProfile()
        {
            CreateMap<SavedFiltersOfApprovedCandidateList, SavedFiltersOfApprovedCandidateListDto>().ReverseMap();
        }
    }
}
