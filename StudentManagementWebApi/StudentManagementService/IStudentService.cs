using StudentManagementWebApi.Dto;

namespace StudentManagementWebApi.StudentManagementService
{
    public interface IStudentService
    {
        public StudentDto AddStudent(StudentDto model);
        public StudentDto GetStudent(int id);
        public StudentDto UpdateStudent(int id, StudentDto model);
        public void DeleteStudent(int id);
        public List<StudentDto> GetAllStudents();
    }
}
