using System.Threading.Tasks;
using RestSharp;

namespace PuppyLoveClient.Models
{
    class ApiHelper
    {
        // public static async Task<string> GetAll()
        // {
        //     RestClient client = new RestClient("http://localhost:5000/api");
        //     RestRequest request = new RestRequest($"dogs", Method.GET);
        //     var response = await client.ExecuteTaskAsync(request);
        //     return response.Content;
        // }

        public static async Task<string> Random(int id)
        {
            RestClient client = new RestClient("http://localhost:5000/api");
            RestRequest request = new RestRequest($"dogs/{id}", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> Get(int id)
        {
            RestClient client = new RestClient("http://localhost:5000/api");
            RestRequest request = new RestRequest($"dogs/{id}", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task Post(string newDog)
        {
            RestClient client = new RestClient("http:localhost:5000/api");
            RestRequest request = new RestRequest($"dogs", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newDog);
            var response = await client.ExecuteTaskAsync(request);
        }

        public static async Task Put(int id, string newDog)
        {
            RestClient client = new RestClient("http://localhost:5000/api");
            RestRequest request = new RestRequest($"dogs/{id}", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newDog);
            var response = await client.ExecuteTaskAsync(request);
        }

        public static async Task Delete(int id)
        {
            RestClient client = new RestClient("http://localhost:5000/api");
            RestRequest request = new RestRequest($"dog/{id}", Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
            var response = await client.ExecuteTaskAsync(request);
        }
    }
}