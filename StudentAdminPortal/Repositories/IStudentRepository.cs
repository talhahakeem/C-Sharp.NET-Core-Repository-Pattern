using StudentAdminPortal.Models.Entities;

namespace StudentAdminPortal.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student? GetById(Guid id);
        Student Add(Student student);
        Student? Update(Student student);
        bool Delete(Guid id);
    }
}