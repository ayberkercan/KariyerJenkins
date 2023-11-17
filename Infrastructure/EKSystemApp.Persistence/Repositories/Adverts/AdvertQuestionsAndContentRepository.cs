﻿using EKSystemApp.Application.Interfaces.Adwerts;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Persistence.Context;
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
        public async Task<ICollection<AdvertAdQuestions>> GetAdwertQuestionAndContent()
        {
            var data = await _context.AdvertAdQuestions.Include(p => p.AnswerContent).ToListAsync();
            return data;
        }
    }
}