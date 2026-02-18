using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.Data;
using StudentAdminPortal.Models;
using StudentAdminPortal.Models.Entities;
using StudentAdminPortal.Repositories;
using StudentAdminPortal.Services;

namespace StudentAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = studentService.GetAllStudents();
            return Ok(students);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetStudentById(Guid id)
        {
            var student = studentService.GetStudentById(id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpPost]
        public IActionResult AddStudent(AddStudentDto addStudentDto)
        {
            var student = studentService.CreateStudent(addStudentDto);
            return Ok(student);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateStudent(Guid id, UpdateStudentDto updateStudentDto)
        {
            var student = studentService.UpdateStudent(id, updateStudentDto);
            if (student == null) return NotFound();
            return Ok(student);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteStudent(Guid id)
        {
            var deleted = studentService.DeleteStudent(id);
            if (!deleted) return NotFound();
            return Ok();
        }
    }
}