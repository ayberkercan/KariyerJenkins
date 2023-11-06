using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA.GeneralSkills
{
    [Table("E_mrs_IseAlimTurkuvaz_M_ProfesyonelBeceriTanimlama")]
    public class M_Skills
    {
        [Key]
        public int ID { get; set; }

        [Column("txtProfesyonelBeceriAd")]
        public string? TxtProfesyonelBeceriAd { get; set; }

        [Column("txtProfesyonelBeceriKod")]
        public string? TxtProfesyonelBeceriKod { get; set; }

        [Column("chkAktif")]
        public int? ChkAktif { get; set; }

        [Column("txtHata")]
        public string? TxtHata { get; set; }
    }
}
