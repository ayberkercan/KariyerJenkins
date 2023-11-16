using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.SalaryType
{
    [Table("IseAlim_UcretTuru")]
    public class SalaryTypes
    {
        [Key]
        public string ID { get; set; }
        public string TANIM { get; set; }
        public int ORDER { get; set; }
    }
}
