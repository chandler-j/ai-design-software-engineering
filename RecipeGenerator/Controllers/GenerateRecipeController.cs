using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using RestSharp;
using RecipeGenerator.Models;
using Newtonsoft.Json;
using System.Text.Json;
using OpenAI_API.Models;

namespace RecipeGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class generateRecipeController : ControllerBase
    {
        // readonly RestClient client;
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            string recipe = await GetRecipe();

            return Ok(recipe);
        }
        public async Task<string> GetRecipe() //call open AI, not secure
        {
            //Gets API Token from Env variable
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            var secretProvider = config.Providers.First();
            secretProvider.TryGet("OpenAIKey", out var OpenAIKey);

            var options = new RestClientOptions("https://api.openai.com")
            {
                MaxTimeout = -1,
            };

            var client = new RestClient(options);
        
            var request = new RestRequest("/v1/chat/completions", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + OpenAIKey);

            var body = @"{" + "\n" +
                @"     ""model"": ""gpt-3.5-turbo""," + "\n" +
                @"     ""max_tokens"":  " + 5 + "," + "\n" +
                @"     ""messages"": [{""role"": ""user"", ""content"": ""provide me a recipe that uses pickled ginger""}]" + "\n" +
                @"   }";
            request.AddStringBody(body, DataFormat.Json);

            RestResponse response = await client.ExecuteAsync(request);
            var payload = JsonConvert.DeserializeObject<Rootobject>(response.Content);

            return payload.choices[0].message.content;
        }
    }
}


