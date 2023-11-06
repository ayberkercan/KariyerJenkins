using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA
{
    [Keyless]
    [Table("E_mrs_IseAlimTurkuvaz_Form_dtyYabanciDil")]
    public class IseAlimForeignLanguagesDataGrid
    {
        public int FORMID { get; set; }
        public int ORDERID { get; set; }
        public int? chkSec_dtyYabanciDil { get; set; }
        public string? cmbYabanciDil_dtyYabanciDil { get; set; }
        public string? cmbYabanciDil_dtyYabanciDil_TEXT { get; set; }
        public string? cmbOkumaSeviye_dtyYabanciDil { get; set; }
        public string? cmbOkumaSeviye_dtyYabanciDil_TEXT { get; set; }
        public string? cmbYazmaSeviye_dtyYabanciDil { get; set; }
        public string? cmbYazmaSeviye_dtyYabanciDil_TEXT { get; set; }
        public string? cmbKonusmaSeviye_dtyYabanciDil { get; set; }
        public string? cmbKonusmaSeviye_dtyYabanciDil_TEXT { get; set; }
    }
}
