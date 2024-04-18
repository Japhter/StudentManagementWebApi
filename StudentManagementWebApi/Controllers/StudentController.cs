using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementWebApi.Data;
using StudentManagementWebApi.Domain;
using StudentManagementWebApi.Dto;
using StudentManagementWebApi.StudentManagementService;

namespace StudentManagementWebApi.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly StudentManagementDBContext _dbContext;
        private readonly IStudentService _service;
        public StudentController(StudentManagementDBContext dBContext, IStudentService service)
        {
            _dbContext = dBContext;
            _service = service;
        }

        [HttpPost]
        [Route("Student/Add")]
        public async Task<ActionResult<StudentDto>> AddStudent(StudentDto model)
        {
            if (model == null)
            {
                return Problem(" model cannot be   null.");
            }
            var IdNumber = _service.GetStudent(model.Id)?.IdNumber;

            if (IdNumber == model.IdNumber)
            {
                return Problem("Student already exist");
            }
            if (model.ProfileImage != null)
            {
                if (model.ProfileImage.Length > 0)
                {
                    if (model.ProfileImage.Length > 2097152)
                    {
                        return BadRequest("Profile image must be no larger than 2MB.");
                    }
                }
            }
            var response = _service.AddStudent(model);

            return response;
        }

        [HttpGet]
        [Route("Student/Get")]
        public async Task<ActionResult<StudentDto>> GetStudent(int id)
        {
            if (id == 0)
            {
                return Problem(" Id cannot be zero.");
            }
            var response = _service.GetStudent(id);

            return response;
        }

        [HttpPut]
        [Route("Student/Update")]
        public async Task<ActionResult<StudentDto>> UpdateStudent(int id, StudentDto model)
        {
            if (id == 0 || model == null)
            {
                return Problem(" Id cannot be zero or model cannot be null .");
            }
            var response = _service.UpdateStudent(id, model);

            return response;
        }

        [HttpDelete]
        [Route("Student/Delete")]
        public async Task DeleteStudent(int id)
        {
            if (id != 0)
                _service.DeleteStudent(id);
        }
        [Route("Change/GetRequestResults")]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetAllStudents()
        {
            var results = _service.GetAllStudents();

            return results;
        }
    }
}
