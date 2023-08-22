﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using RestSharp;
using RecipeGenerator.Models;
using Newtonsoft.Json;
using System.Text.Json;

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
            RestResponse response = await GetRecipe();

            Console.WriteLine(response.Content);
            
            return Ok(response.Content);
        }

        public async Task<RestResponse> GetRecipe() //call open AI, not secure
           
        {
            var options = new RestClientOptions("https://api.openai.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/v1/chat/completions", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer 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");
            var body = @"{" + "\n" +
            @"     ""model"": ""gpt-3.5-turbo""," + "\n" +
            @"     ""messages"": [{""role"": ""user"", ""content"": ""provide me a recipe that uses pickled ginger""}]" + "\n" +
            @"   }";
            request.AddStringBody(body, DataFormat.Json);
            
            RestResponse response = await client.ExecuteAsync(request);
           // OpenAIResponse payload = new OpenAIResponse();
            var payload = JsonConvert.DeserializeObject<Rootobject>(response.Content);
            //Console.WriteLine(response.Content);
            return response;
        }
    }
}


