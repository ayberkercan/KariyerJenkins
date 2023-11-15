using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Member.CountriesTree
{
    public class CountryTreeDto
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public ICollection<ProvinceTreeDto> Provinces { get; set; }
    }
}
