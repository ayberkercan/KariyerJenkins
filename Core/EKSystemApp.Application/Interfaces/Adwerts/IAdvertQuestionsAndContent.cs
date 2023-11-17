using EKSystemApp.Application.DTO.AdQuestion;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.Application.Interfaces.Adwerts
{
    public interface IAdvertQuestionsAndContent
    {
        Task<List<AdvertAdQuestions>> GetAdwertQuestionAndContent();
    }
}
