using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA
{
    [Table("GOREVLER_FULL_SAP")]
    public class GorevlerFullSap
    {
        [Key]
        public string ID { get; set; }
        public string UNVAN_TANIM { get; set; }
    }
}
