using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.ApplicationSource
{
    [Table("E_mrs_IseAlimTurkuvaz_M_BasvuruKaynagiTanimlama")]
    public class M_ApplicationSources
    {
        [Key]
        public int ID { get; set; }

        [Column("txtBasvuruKaynakAd")]
        public string? ApplicationSourceName { get; set; }

        [Column("txtBasvuruKaynakKod")]
        public string? ApplicationSourceCode { get; set; }

        [Column("chkAktif")]
        public int? ChkAktif { get; set; }

        [Column("txtHata")]
        public string? TxtHata { get; set; }
    }
}
