using AutoMapper;
using EKSystemApp.Application.DTO.AdQuestion;
using EKSystemApp.Application.DTO.AdvertQuestionsDefinations.List;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.Mappings.AdQuestionMap
{
    public class AdQuestionProfile:Profile
    {
        public AdQuestionProfile()
        {
            this.CreateMap<AdvertAdQuestions , AdQuestionsDto>().ReverseMap();
            this.CreateMap<AdQuestionsDto, GetAdvertQuestionListDto>().ReverseMap();
        }
    }
}
