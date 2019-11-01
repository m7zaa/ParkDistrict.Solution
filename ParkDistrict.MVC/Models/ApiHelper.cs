using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace ParkDistrict.Models
{
    class ApiHelper
    {
        public static async Task<string> ApiCallIndex()
        {
            RestClient client = new RestClient("http://localhost:5000/api/parks");
            RestRequest request = new RestRequest(Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> ApiCallIndexSearch(string search)
        {
            RestClient client = new RestClient("http://localhost:5000/api/parks");
            RestRequest request = new RestRequest(Method.GET);
            request.AddParameter("flex", search);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> ApiCallDetails(int id)
        {
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("/api/parks/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> ApiCallCreate(Park park)
        {
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("api/parks", Method.POST);
            request.AddJsonBody(park);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> ApiCallDelete(int id)
        {
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("api/parks/{id}", Method.DELETE);
            request.AddUrlSegment("id", id);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> ApiCallEdit(Park park)
        {
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("api/parks/{id}", Method.PUT);
            request.AddUrlSegment("id", park.ParkId);
            request.AddJsonBody(park);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
    }
}