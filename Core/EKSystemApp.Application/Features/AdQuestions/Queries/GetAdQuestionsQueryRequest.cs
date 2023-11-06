using EKSystemApp.Application.DTO.AdQuestion;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Features.AdQuestions.Questions
{
    public class GetAdQuestionsQueryRequest:IRequest<ICollection<AdQuestionsDto>>
    {
    }
}
