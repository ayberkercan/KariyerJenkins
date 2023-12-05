using EKSystemApp.Application.DTO.AdvertQuestionsDefinations.List;
using EKSystemApp.Application.Interfaces.Adwerts;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Persistence.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EKSystemApp.Persistence.Repositories.Adverts
{
    public class AdvertQuestionsAndContentRepository : IAdvertQuestionsAndContent
    {
        private readonly ApplicationDbContext _context;
        public AdvertQuestionsAndContentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<GetAdvertQuestionListDto>> GetAdwertQuestionAndContent()
        {
            var data = await _context.AdvertAdQuestionAnswerContent.Include(p => p.AdvertAdQuestions).Select(p => new { p.Id, p.AnswerContentName, p.AdvertAdQuestions.AdQuestionName, p.AdvertAdQuestions.AnswerContentDefination, p.AdvertAdQuestions.AnswerType }).AsNoTracking().ToListAsync();

            List<GetAdvertQuestionListDto> list = new List<GetAdvertQuestionListDto>();
            foreach (var item in data) {
                var result = new GetAdvertQuestionListDto
                {
                    AdQuestionName = item.AdQuestionName,
                    AnswerContentDefination = item.AnswerContentDefination,
                    AnswerContentName = item.AnswerContentName,
                    Id = item.Id,
                    AnswerContentType = item.AnswerType
                };
                list.Add(result);
            }
            return list;
        }
    }
}
