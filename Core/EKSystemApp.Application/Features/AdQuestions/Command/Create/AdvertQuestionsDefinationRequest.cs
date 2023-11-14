using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Application.DTO.AdQuestion;
using EKSystemApp.Application.DTO.AdvertQuestionsDefinations.Create;
using MediatR;

namespace EKSystemApp.Application.Features.AdQuestions.Command.Create
{
    public class AdvertQuestionsDefinationRequest : IRequest<AdQuestionsDto>
    {
        public string AdQuestionName { get; set; }
        public string AnswerType { get; set; }
        public string? AnswerContent { get; set; }
        public Guid? AdvertCreateId { get; set; }
    }
}
