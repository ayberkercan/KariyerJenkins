namespace EKSystemApp.Application.DTO.Member.Education.UniversitiesTree
{
    public class UniversityTreeDto
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public ICollection<EducationDepartmentTreeDto> Departments { get; set; }
    }
}
