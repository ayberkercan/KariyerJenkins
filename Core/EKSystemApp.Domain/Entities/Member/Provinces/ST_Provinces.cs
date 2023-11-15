using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.Provinces
{
    [Table("IseAlim_Iller")]
    public class ST_Provinces
    {
        [Key]
        public int PLAKA { get; set; }
        public string ISIM { get; set; }
    }
}
