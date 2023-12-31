﻿using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class AdvertAdQuestionAnswerContent:BaseEntity
    {
        public Guid? AdvertAdQuestionsId { get; set; }
        public AdvertAdQuestions? AdvertAdQuestions { get; set; }
        public string? AnswerContentKey { get; set; }
        public string? AnswerContentName { get; set; }
    }
}
