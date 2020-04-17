using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ContosoUniversity.Data
{
    public class StudentInMemoryRepository : IStudentRepository
{
    public Task CreateStudentAsync(Student student)
    {
        throw new System.NotImplementedException();
    }

    public Task DeleteStudentAsync(int? id)
    {
        throw new System.NotImplementedException();
    }

    public Task<Student> GetStudentById(int? id)
    {
        throw new System.NotImplementedException();
    }

    public async Task<Student> GetStudentByIdAsync(int id)
    {
        return new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")};
    }

        public Task<Student> GetStudentByIdAsync(int? id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Student>> GetStudentsAsync()
    {
            var students = new List<Student>
                {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
                };
        return students ;
    }

    public Task UpdateStudentAsync(Student student)
    {
        throw new System.NotImplementedException();
    }

    
}
}
