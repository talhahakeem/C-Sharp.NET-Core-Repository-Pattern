using StudentAdminPortal.Data;
using StudentAdminPortal.Models.Entities;

namespace StudentAdminPortal.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext dbContext;

        public StudentRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Student> GetAll()
        {
            return dbContext.Students.ToList();
        }

        public Student? GetById(Guid id)
        {
            return dbContext.Students.Find(id);
        }

        public Student Add(Student student)
        {
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
            return student;
        }
        public Student? Update(Student student)
        {
            dbContext.SaveChanges();
            return student;
        }

        public bool Delete(Guid id)
        {
            var student = dbContext.Students.Find(id);
            if (student == null) return false;

            dbContext.Students.Remove(student);
            dbContext.SaveChanges();
            return true;
        }
    }
}