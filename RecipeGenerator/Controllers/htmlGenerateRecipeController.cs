using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using RestSharp;
using RecipeGenerator.Models;
using Newtonsoft;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;
using System.Linq;

namespace RecipeGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class generateRecipeController : ControllerBase
    {
        // readonly RestClient client;
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    RestResponse response = await GetRecipeHTML();

        //    Console.WriteLine(response.Content);
            
        //    return Ok(response.Content);
        //}

        //public async Task<RestResponse> GetRecipeHTML() //call open AI, not secure
           
        //{
        //    var html = "empty";
        //    var options = new RestClientOptions("https://api.openai.com")
        //    {
        //        MaxTimeout = -1,
        //    };
        //    var client = new RestClient(options);
        //    var request = new RestRequest("/v1/chat/completions", Method.Post);
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddHeader("Authorization", "Bearer **********************");
        //    var body = @"{" + "\n" +
        //    @"     ""model"": ""gpt-3.5-turbo""," + "\n" +
        //    @"     ""messages"": [{""role"": ""user"", ""content"": ""provide me a recipe that uses pickled ginger""}]" + "\n" +
        //    @"   }";
        //    request.AddStringBody(body, DataFormat.Json);
            
        //    //RestResponse response = await client.ExecuteAsync(request);

        //    using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
        //    using (Stream stream = response.GetResponseStream())

        //    using (StreamReader reader = new StreamReader(response))
        //    {
        //        html = await reader.ReadToEndAsync();
        //    }
        //    Rootobject jsonObjects = new Rootobject();

        //    OpenAIResponse payload = new OpenAIResponse();
        //    jsonObjects = JsonSerializer.Deserialize<Rootobject>(html);
        //    //Console.WriteLine(response.Content);
        //    //return response;
        //    return jsonObjects;
        //}
    }
}