using EKSystemApp.Application.DTO.AdQuestion;
using EKSystemApp.Application.DTO.AdvertQuestionsDefinations.List;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.AdQuestions.Questions
{
    public class GetAdQuestionsQueryRequest:IRequest<ICollection<GetAdvertQuestionListDto>>
    {
    }
}
