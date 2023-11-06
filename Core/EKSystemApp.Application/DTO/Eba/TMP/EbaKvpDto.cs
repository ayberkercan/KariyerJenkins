using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Eba.TMP
{
    public class EbaKvpDto
    {
        public int? Key { get; set; }
        public string? Value { get; set; }
    }

    public class EbaStrKvpDto
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
    }

    public class EbaGorevTempDto
    {
        public int? UpObjectId { get; set; }
        public string? Pozisyon { get; set; }
    }

    public class ForeignLanguagesDto
    {
        public EbaStrKvpDto? Language { get; set; }
        public EbaStrKvpDto? ReadingLevel { get; set; }
        public EbaStrKvpDto? WritingLevel { get; set; }
        public EbaStrKvpDto? SpeakingLevel { get; set; }
    }

    public class GeneralSkillsDto
    {
        public EbaStrKvpDto? GeneralSkill { get; set; }
        public EbaStrKvpDto? GeneralSkillLevel { get; set; }
    }
}
