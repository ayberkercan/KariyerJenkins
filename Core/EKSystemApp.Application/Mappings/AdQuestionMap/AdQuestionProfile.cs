using AutoMapper;
using EKSystemApp.Application.DTO.AdQuestion;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;

namespace EKSystemApp.Application.Mappings.AdQuestionMap
{
    public class AdQuestionProfile:Profile
    {
        public AdQuestionProfile()
        {
            this.CreateMap<AdvertAdQuestions , AdQuestionsDto>().ReverseMap();
        }
    }
}
//lkşsajdikasda