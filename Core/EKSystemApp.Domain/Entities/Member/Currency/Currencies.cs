using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.Currency
{
    [Table("IseAlim_ParaBirimi")]
    public class Currencies
    {
        [Key]
        public string ID { get; set; }
        public string TANIM { get; set; }
        public int ORDER { get; set; }
    }
}
