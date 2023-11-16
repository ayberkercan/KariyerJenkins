using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.AreaCodes
{
    [Keyless]
    [Table("TBL_ULKE")]
    public class CountryAreaCodes
    {
        [Column("KODU")]
        public string CountryCode { get; set; }
        [Column("ULKE_ALANKOD")]
        public string CountryAreaCode { get; set; }
    }
}
