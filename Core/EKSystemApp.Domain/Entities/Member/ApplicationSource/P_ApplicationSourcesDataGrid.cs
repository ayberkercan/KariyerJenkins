using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.Member.ApplicationSource
{
    [Keyless]
    [Table("E_mrs_IseAlimTurkuvaz_P_BasvuruKaynagiTanimlama_dtyBasvuruKaynak")]
    public class P_ApplicationSourcesDataGrid
    {
        public int FORMID { get; set; }
        public int ORDERID { get; set; }
        public int DOCUMENTID { get; set; }
        public int CHECKED { get; set; }
    }
}
