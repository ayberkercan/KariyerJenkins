using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EKSystemApp.Domain.Entities.Member.TurkuvazCompanies
{
    [Table("E_mrs_IseAlimTurkuvaz_M_CalisilacakSirketTanimlama")]
    public class M_TurkuvazCompanies
    {
        [Key]
        public int ID { get; set; }

        [Column("txtSirketAd")]
        public string? CompanyName { get; set; }

        [Column("txtSirketKod")]
        public string? CompanyCode { get; set; }

        [Column("chkAktif")]
        public int? ChkAktif { get; set; }

        [Column("txtHata")]
        public string? TxtHata { get; set; }
    }
}
