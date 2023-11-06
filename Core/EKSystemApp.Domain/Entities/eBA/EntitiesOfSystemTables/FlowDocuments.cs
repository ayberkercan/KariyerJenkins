using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA.EntitiesOfSystemTables
{
    [Table("FLOWDOCUMENTS")]
    public class FlowDocuments
    {
        [Key]
        public int PROCESSID { get; set; }
        public string FILEPATH { get; set; }
        public int FILEPROFILEID { get; set; }
        public string PARENTFILEPATH { get; set; }
        public string NODECAPTION { get; set; }
        public DateTime RELATIONDATE { get; set; }
        public int RELATIONTYPE { get; set; }
    }
}
