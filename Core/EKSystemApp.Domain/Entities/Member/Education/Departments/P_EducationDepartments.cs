using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.Education.Departments
{
    [Table("E_mrs_IseAlimTurkuvaz_P_BolumTanimlama")]
    public class P_EducationDepartments
    {
        [Key]
        public int ID { get; set; }
    }
}
