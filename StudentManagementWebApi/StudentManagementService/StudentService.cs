using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using StudentManagementWebApi.Dto;
using Microsoft.AspNetCore.Mvc;
using StudentManagementWebApi.Domain;
using AutoMapper;
using StudentManagementWebApi.Data;


namespace StudentManagementWebApi.StudentManagementService
{
    public class StudentService : IStudentService
    {
        private readonly IMapper _mapper;
        private StudentManagementDBContext _context;
        public StudentService(IMapper mapper, StudentManagementDBContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public StudentDto AddStudent(StudentDto model)
        {
            var student = _mapper.Map<Student>(model);

            _context.Students.Add(student);
            _context.SaveChangesAsync();

            return _mapper.Map<StudentDto>(student);
        }

        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            
            _context.Students.Remove(student);
            _context.SaveChangesAsync();
        }

        public List<StudentDto> GetAllStudents()
        {
            var students = _context.Students.ToList();

            return _mapper.Map<List<StudentDto>>(students); ;
        }

        public StudentDto GetStudent(int id)
        {
            var student = _context.Students.FindAsync(id);

            return _mapper.Map<StudentDto>(student); ;
        }

        public StudentDto UpdateStudent(int id, StudentDto model)
        {

            var student = _context.Students.FindAsync(id);
           
            _mapper.Map(model, student);
            _context.SaveChangesAsync();

            return _mapper.Map<StudentDto>(student);
        }
    }
}
