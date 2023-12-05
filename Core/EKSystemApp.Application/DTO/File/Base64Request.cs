using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.File
{
    public class Base64Request
    {
        public string Base64String { get; set; }
        public string FileName { get; set; }
    }
    
    public class Base64Response
    {
        public byte[] FileBytes { get; set; }
        public string FileName { get; set; }
    }
}
