using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.Education.Departments
{
    [Table("E_mrs_IseAlimTurkuvaz_M_BolumTanimlama")]
    public class M_EducationDepartments
    {
        [Key]
        public int ID { get; set; }

        [Column("txtBolum")]
        public string? DepartmentName { get; set; }

        [Column("txtBolumKod")]
        public string? DepartmentCode { get; set; }

        [Column("chkAktif")]
        public int? ChkAktif { get; set; }

        [Column("txtHata")]
        public string? TxtHata { get; set; }
    }
}
