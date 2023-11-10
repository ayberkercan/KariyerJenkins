using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Member.CountriesTree
{
    public class ProvinceTreeDto
    {
        public int Upkey { get; set; }
        public int Key { get; set; }
        public string Value { get; set; }
        public ICollection<CityTreeDto> Cities { get; set; }
    }
}
