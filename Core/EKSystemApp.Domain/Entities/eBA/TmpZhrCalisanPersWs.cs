using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EKSystemApp.Domain.Entities.eBA
{
    [Table("TMP_ZHRCALISANPERSWS")]
    public class TmpZhrCalisanPersWs
    {
        [Key]
        public string USERID { get; set; }
        public string? FIRSTNAME { get; set; }
        public string? LASTNAME { get; set; }
        public DateTime? DOGUMTARIHI { get; set; }
        public string? EMPLOYEMENTSTART { get; set; }
        public string? DEPARTMENT { get; set; }
        public string? DEPARTMENTNAME { get; set; }
        public string? PROFESSION { get; set; }
        public string? PROFESSIONNAME { get; set; }
        public string? POSITION { get; set; }
        public string? POSITIONNAME { get; set; }
        public string? MANAGERUSERID { get; set; }
        public string? EMAIL { get; set; }
        public string? TELEFON { get; set; }
        public string? COMPANY { get; set; }
        public string? COMPANYNAME { get; set; }
        public string? ZONAYCI1 { get; set; }
        public string? ZONAYCI2 { get; set; }
        public string? ZONAYCI3 { get; set; }
        public string? ZONAYCI4 { get; set; }
        public string? ZONAYCI5 { get; set; }
        public string? STAT2 { get; set; }
        public string? BEGDA { get; set; }
        public string? ENDDA { get; set; }
        public string? ZORG { get; set; }
        public string? ORGTX { get; set; }
        public string? ZGRUP { get; set; }
        public string? GRUPTX { get; set; }
        public string? ZBOLUM { get; set; }
        public string? BOLUMTX { get; set; }
        public string? ZBIRIM { get; set; }
        public string? BIRIMTX { get; set; }
        public string? ZSONONAYCI { get; set; }
        public string? IKONAYCI { get; set; }
        public string? MASTERORGIDS { get; set; }
        public string? DAHILINO { get; set; }
        public string? ORGKEY { get; set; }
        public string? LOCATION { get; set; }
        public string? CONTRACT { get; set; }
        public string? DOMAIN { get; set; }
        public string? TUZEL { get; set; }
        public string? POSITION_ID { get; set; }
        public string? PERSONELALTALAN { get; set; }
        public string? CALISANGRUBU { get; set; }
        public string? CALISANALTGRUBU { get; set; }
        public string? TCKN { get; set; }
        public string? ISALANI { get; set; }
    }
}
