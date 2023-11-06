using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA.ForeignLanguages
{
    [Table("E_mrs_IseAlimTurkuvaz_M_YabanciDilTanimlama")]
    public class M_Languages
    {
        [Key]
        public int ID { get; set; }

        [Column("txtYabanciDilAd")]
        public string? TxtYabanciDilAd { get; set; }

        [Column("txtYabanciDilKod")]
        public string? TxtYabanciDilKod { get; set; }

        [Column("chkAktif")]
        public int? ChkAktif { get; set; }

        [Column("txtHata")]
        public string? TxtHata { get; set; }
    }
}
