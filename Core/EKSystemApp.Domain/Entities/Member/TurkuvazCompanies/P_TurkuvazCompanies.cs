using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.TurkuvazCompanies
{
    [Table("E_mrs_IseAlimTurkuvaz_P_CalisilacakSirketTanimlama")]
    public class P_TurkuvazCompanies
    {
        [Key]
        public int ID { get; set; }
    }
}
