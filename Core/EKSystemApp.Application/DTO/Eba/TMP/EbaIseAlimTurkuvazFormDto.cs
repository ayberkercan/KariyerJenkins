using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Eba.TMP
{
    public class EbaIseAlimTurkuvazFormDto
    {
        public int Id { get; set; }
        public int ProcessId { get; set; }
        public EbaStrKvpDto? Organization { get; set; }
        public EbaStrKvpDto? Group { get; set; }
        public EbaStrKvpDto? Department { get; set; }
        public EbaStrKvpDto? Unit { get; set; }
        public EbaStrKvpDto? Profession { get; set; }
        public EbaStrKvpDto? Position { get; set; }
        public EbaStrKvpDto? ShiftStatus { get; set; }
        public EbaStrKvpDto? MilitaryStatus { get; set; }
        public EbaStrKvpDto? EducationStatus { get; set; }
        public EbaStrKvpDto? StaffType { get; set; }
        public EbaStrKvpDto? WorkingType { get; set; }
        public EbaStrKvpDto? Location { get; set; }
        public List<ForeignLanguagesDto>? ForeignLanguages { get; set; }
        public List<GeneralSkillsDto>? GeneralSkills { get; set; }
        public EbaStrKvpDto? Gender { get; set; }
        public string? Description { get; set; }
    }
}
