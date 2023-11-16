using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EKSystemApp.Domain.Entities.Member.TurkuvazCompanies
{
    [Keyless]
    [Table("E_mrs_IseAlimTurkuvaz_P_CalisilacakSirketTanimlama_dtyCalisilacakSirket")]
    public class P_TurkuvazCompaniesDataGrid
    {
        public int FORMID { get; set; }
        public int ORDERID { get; set; }
        public int DOCUMENTID { get; set; }
        public int CHECKED { get; set; }
    }
}
