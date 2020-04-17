

using ContosoUniversity.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Services
{

    public class ClientService
    {
        public async Task<bool> CreateStudent(Student student)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(student);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            var response = await httpClient.PostAsync("https://localhost:44312/api/Students", content);
            return response.StatusCode == System.Net.HttpStatusCode.Created;
        }
        public async Task<Student> DeleteStudentById(int? id)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync("https://localhost:44312/api/Students/" + id);
            return JsonConvert.DeserializeObject<Student>(response);
        }

        public async Task<List<Student>> GetStudents()
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync("https://localhost:44312/api/Students");
            return JsonConvert.DeserializeObject<List<Student>>(response);
        }

        public async Task<Student> GetStudentById(int? id)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync("https://localhost:44312/api/Students/" + id);
            return JsonConvert.DeserializeObject<Student>(response);
        }

        public async Task<bool> UpdateStudent(Student student)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(student);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("https://localhost:44312/api/Students", content);
            return response.StatusCode == System.Net.HttpStatusCode.Created;
        }


    }
}
