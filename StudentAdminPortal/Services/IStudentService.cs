using StudentAdminPortal.Models;
using StudentAdminPortal.Models.Entities;

namespace StudentAdminPortal.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student? GetStudentById(Guid id);
        Student CreateStudent(AddStudentDto dto);
        Student? UpdateStudent(Guid id, UpdateStudentDto dto);
        bool DeleteStudent(Guid id);
    }
}