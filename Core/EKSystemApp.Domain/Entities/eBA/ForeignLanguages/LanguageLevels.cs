using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA.ForeignLanguages
{
    [Table("IseAlim_YabanciDilDuzeyi")]
    public class LanguageLevels
    {
        public string ID { get; set; }
        public string TANIM { get; set; }
        public int ORDER { get; set; }
    }
}
