using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace ParkDistrict.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool Playground { get; set; }
        public bool PicnicArea { get; set; }

        public static List<Park> ParkListSearch(string search)
        {
            List<Park> park;
            if (string.IsNullOrEmpty(search))
            {
                var apiCallTask = ApiHelper.ApiCallIndex();
                var result = apiCallTask.Result;

                JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
                park = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());
            }
            else
            {
                var apiCallTask = ApiHelper.ApiCallIndexSearch(search);
                var result = apiCallTask.Result;

                JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
                park = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());
            }
            return park;
        }

        public static Park ParkDetails(int id)
        {
            var apiCallTask = ApiHelper.ApiCallDetails(id);
            var result = apiCallTask.Result;
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Park mushroom = JsonConvert.DeserializeObject<Park>(jsonResponse.ToString());
            Console.WriteLine(mushroom);
            return mushroom;
        }

        public async Task<int> ParkCreate()
        {
            var result = await ApiHelper.ApiCallCreate(this);
            return 0;
        }

        public async static Task<int> ParkDelete(int id)
        {
            Console.WriteLine($"mushroom delete id = {id}");
            var result = await ApiHelper.ApiCallDelete(id);
            return 0;
        }

        public async static Task<int> ParkEdit(Park mushroom)
        {
            var result = await ApiHelper.ApiCallEdit(mushroom);
            return 0;
        }

    }
}