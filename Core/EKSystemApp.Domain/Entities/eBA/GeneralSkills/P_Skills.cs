using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA.GeneralSkills
{
    [Table("E_mrs_IseAlimTurkuvaz_P_ProfesyonelBeceriTanimlama")]
    public class P_Skills
    {
        [Key]
        public int ID { get; set; }
    }
}
