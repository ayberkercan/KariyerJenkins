using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA
{
    [Table("TMP_ZHRORGANIZATIONTREEDR")]
    public class TmpOrganizationTreeDr
    {
        [Key]
        public int OBJID { get; set; }
        public int UP_OBJID { get; set; }
        public string ORGTX { get; set; }
        public string SEVIYE { get; set; }
        public string POZISYON { get; set; }
        public string UNVAN { get; set; }
        [Column("1_ONAYCI")]
        public string BIRINCIONAYCI { get; set; }
    }
}