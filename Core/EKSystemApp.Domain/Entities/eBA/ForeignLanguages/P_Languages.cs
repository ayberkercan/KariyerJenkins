using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA.ForeignLanguages
{
    [Table("E_mrs_IseAlimTurkuvaz_P_YabanciDilTanimlama")]
    public class P_Languages
    {
        [Key]
        public int ID { get; set; }
    }
}
