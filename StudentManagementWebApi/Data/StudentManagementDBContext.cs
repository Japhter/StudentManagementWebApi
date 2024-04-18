using Microsoft.EntityFrameworkCore;
using StudentManagementWebApi.Domain;

namespace StudentManagementWebApi.Data
{
    public class StudentManagementDBContext  :DbContext
    {
        public StudentManagementDBContext(DbContextOptions<StudentManagementDBContext>options) :base(options) { }
        public DbSet<Student> Students { get; set; }    
        public DbSet<Enrolment> Enrolments { get; set; }    
    }
}
