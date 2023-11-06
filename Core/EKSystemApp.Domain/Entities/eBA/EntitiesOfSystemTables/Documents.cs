using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA.EntitiesOfSystemTables
{
    [Table("DOCUMENTS")]
    public class Documents
    {
        [Key]
        public int ID { get; set; }
        public int STATUS { get; set; }
        public int CREATOR { get; set; }
        public int DELETED { get; set; }
        public int DOCUMENTVERSION { get; set; }
        public int OWNERDOCID { get; set; }
        public int OWNERPROCESSID { get; set; }
        public int TEMPLATEVERSION { get; set; }
        public int TEST { get; set; }
        public int PROJECTVERSION { get; set; }
        public int? INDEXSTATUS { get; set; }
        public int? ISREADONLY { get; set; }
        public int? LIBRARYID { get; set; }
        public int? FOLDERID { get; set; }
        public int? FILEID { get; set; }
        public string USERID { get; set; }
        public string CREATORUSERID { get; set; }
        public string PROCESS { get; set; }
        public string FORM { get; set; }
        public string? DOCUMENTID { get; set; }
        public DateTime CREATEDATE { get; set; }
    }
}
