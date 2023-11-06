using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Eba.TMP
{
    public class TmpOrganizationTreeDto
    {
        public int OBJID { get; set; }
        public int UP_OBJID { get; set; }
        public string ORGTX { get; set; }
        public string SEVIYE { get; set; }
        public string POZISYON { get; set; }
        public string UNVAN { get; set; }
        public string BIRINCIONAYCI { get; set; }
    }
}
