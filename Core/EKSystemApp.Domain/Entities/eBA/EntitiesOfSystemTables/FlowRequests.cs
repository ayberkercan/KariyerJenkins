using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Domain.Entities.eBA.EntitiesOfSystemTables
{
    [Table("FLOWREQUESTS")]
    public class FlowRequests
    {
        [Key]
        public int ID { get; set; }
        public int PROCESSID { get; set; }
        public int ORDERNO { get; set; }
        public int REQUESTTYPE { get; set; }
        public int STATUS { get; set; }
        public int EVENTFORMID { get; set; }
        public int FOLLOWSTATUS { get; set; }
        public int APPROVER { get; set; }
        public int STEP { get; set; }
        public int DELETEDFROMLIST { get; set; }
        public int APPROVERHIDDEN { get; set; }
        public int AUTOOPEN { get; set; }
        public int VISIBLE { get; set; }
        public int TIMEOUTDAYS { get; set; }
        public int TIMEOUTHOURS { get; set; }
        public int TIMEOUTMINUTES { get; set; }
        public int CALCWORKINGHOURS { get; set; }
        public int CALCHOLIDAYS { get; set; }
        public int PERSONAL { get; set; }
        public int TRYCOUNT { get; set; }
        public int? OWNEDBY { get; set; }
        public int? OWNENABLED { get; set; }
        public DateTime REQUESTDATE { get; set; }
        public DateTime? OWNEDDATE { get; set; }
        public DateTime? RESPONSEDATE { get; set; }
        public string? REASON { get; set; }
        public string EVENTTEXT { get; set; }
        public string DESCRIPTION { get; set; }
        public string EVENTICON { get; set; }
        public string PROCESS { get; set; }
        public string FLOWOBJECT { get; set; }
        public string? FLAGCOLOR { get; set; }
        public string? POSITION { get; set; }
        public string? USERID { get; set; }
        public string? APPROVERUSERID { get; set; }
    }
}
