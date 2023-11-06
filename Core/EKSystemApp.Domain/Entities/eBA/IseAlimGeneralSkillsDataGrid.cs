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
    [Table("E_mrs_IseAlimTurkuvaz_Form_dtyGenelYetkinlik")]
    public class IseAlimGeneralSkillsDataGrid
    {
        public int FORMID { get; set; }
        public int ORDERID { get; set; }
        public int? chkSec_dtyGenelYetkinlik { get; set; }
        public string? cmbGenelYetkinlik_dtyGenelYetkinlik { get; set; }
        public string? cmbGenelYetkinlik_dtyGenelYetkinlik_TEXT { get; set; }
        public string? cmbSeviye_dtyGenelYetkinlik { get; set; }
        public string? cmbSeviye_dtyGenelYetkinlik_TEXT { get; set; }
    }
}
