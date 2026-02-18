using StudentAdminPortal.Models;
using StudentAdminPortal.Models.Entities;
using StudentAdminPortal.Repositories;

namespace StudentAdminPortal.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repository;

        public StudentService(IStudentRepository repository)
        {
            this.repository = repository;
        }

        public List<Student> GetAllStudents()
        {
            return repository.GetAll();
        }
        public Student? GetStudentById(Guid id)
        {
            return repository.GetById(id);
        }

        public Student CreateStudent(AddStudentDto dto)
        {
            var student = new Student
            {
                Name = dto.Name,
                Email = dto.Email,
                Phone = dto.Phone,
                Fees = dto.Fees
            };
            return repository.Add(student);
        }
        public Student? UpdateStudent(Guid id, UpdateStudentDto dto)
        {
            var student = repository.GetById(id);
            if (student == null) return null;

            student.Name = dto.Name; 
            student.Email = dto.Email;
            student.Phone = dto.Phone; 
            student.Fees = dto.Fees;

            return repository.Update(student);
        }

        public bool DeleteStudent(Guid id)
        {

           return repository.Delete(id);
        }
    }
}