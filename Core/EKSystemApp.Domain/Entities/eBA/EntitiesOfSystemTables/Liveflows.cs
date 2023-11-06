using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA.EntitiesOfSystemTables
{
    [Table("LIVEFLOWS")]
    public class LiveFlows
    {
        public int ID { get; set; }
        public string PROCESS { get; set; }
        public string USERID { get; set; }
        public int STARTER { get; set; }
        public string STARTERUSERID { get; set; }
        public DateTime? RDATE { get; set; }
        public int FINISHED { get; set; }
        public DateTime? FDATE { get; set; }
        public string FLOW { get; set; }
        public int FLOWVERSION { get; set; }
        public int FLOWSTEP { get; set; }
        public int STATUS { get; set; }
        public int CONTENTVERSION { get; set; }
        public int DELETED { get; set; }
        public int CODEVERSION { get; set; }
        public int OWNERPROCESSID { get; set; }
        public int TEST { get; set; }
        public int PROJECTVERSION { get; set; }
    }
}
