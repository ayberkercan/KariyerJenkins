using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.ApplicationSource
{
    [Table("E_mrs_IseAlimTurkuvaz_P_BasvuruKaynagiTanimlama")]
    public class P_ApplicationSources
    {
        [Key]
        public int ID { get; set; }
    }
}
