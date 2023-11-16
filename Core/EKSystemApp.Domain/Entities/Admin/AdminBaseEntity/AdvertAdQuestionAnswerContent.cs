using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities.Admin.AdminBaseEntity
{
    public class AdvertAdQuestionAnswerContent:BaseEntity
    {
        public Guid? AdvertAdQuestionsId { get; set; }
        public AdvertAdQuestions? AdvertAdQuestions { get; set; }
        public string? Name { get; set; }
    }
}
