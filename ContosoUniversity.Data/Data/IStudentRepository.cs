using ContosoUniversity.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public interface IStudentRepository
    {
        Task CreateStudentAsync(Student student);
        Task DeleteStudentAsync(int? id);
        Task<Student> GetStudentById(int? id);
        Task<Student> GetStudentByIdAsync(int? id);
        Task<List<Student>> GetStudentsAsync();
        Task UpdateStudentAsync(Student student);
    }
}