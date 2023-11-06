using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA
{
    [Table("IseAlim_CalismaTuru")]
    public class WorkingType
    {
        [Key]
        public int ID { get; set; }
        public string TANIM { get; set; }
    }
}
