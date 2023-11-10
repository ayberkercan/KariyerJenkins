using EKSystemApp.Application.DTO.Member.Education.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Member.Education.UniversitiesTree
{
    public class UniversityTreeDto
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public ICollection<EducationDepartmentTreeDto> Departments { get; set; }
    }
}
