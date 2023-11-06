using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA.GeneralSkills
{
    [Keyless]
    [Table("E_mrs_IseAlimTurkuvaz_P_ProfesyonelBeceriTanimlama_dtyProfesyonelBeceri")]
    public class P_SkillsDataGrid
    {
        public int FORMID { get; set; }
        public int ORDERID { get; set; }
        public int DOCUMENTID { get; set; }
        public int CHECKED { get; set; }
    }
}
