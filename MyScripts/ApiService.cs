

namespace Contoso.Services
{
    

        
        public async Task<bool> CreateStudent(Student student)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(instructor);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            var response = await httpClient.PostAsync("url/api/Students", content);
            return response.StatusCode == HttpStatusCode.Created;
        }

        public async Task<List<Trainers>> GetStudents()
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync("url/api/Students");
            return JsonConvert.DeserializeObject<List<Student>>(response);
        }

        public async Task<Trainers> GetInstructor(int id)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync("https://url/api/Students/" + id);
            return JsonConvert.DeserializeObject<Student>(response);
        }

        
        

    }
}
