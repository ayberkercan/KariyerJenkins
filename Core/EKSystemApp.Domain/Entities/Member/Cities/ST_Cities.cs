using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.Cities
{
    [Table("IseAlim_Ilceler")]
    public class ST_Cities
    {
        [Key]
        public int ID { get; set; }
        public string ISIM { get; set; }
        public int IL_ID { get; set; }
    }
}
