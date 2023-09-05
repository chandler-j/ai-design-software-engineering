using Newtonsoft.Json;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels;
using RecipeGenerator.Models;
using RecipeGenerator.Constant;
using RecipeGenerator.Interfaces;
using OpenAI.Managers;

namespace RecipeGenerator.Repository
{
    public class OpenAITask
{

        private readonly IServiceConfigurations _service;

        public OpenAITask(IServiceConfigurations service)
        {
            _service = service;
        }

        public async Task<string> GetRecipe(string? ingredients, string? cuisine)
        {
            if (cuisine == "") cuisine = "any cuisine";
            var recipe = await CreateRecipeRequest(ingredients, cuisine, 1000);

            return recipe;
        }
        private async Task<string> CreateRecipeRequest(string? ingredients, string? cuisine, int maxTokens) //call open AI, not secure
        {
            string payload = "";

            var completionResult = await _service.GetOpenAI().ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = new List<ChatMessage> { 
    
                ChatMessage.FromSystem("You are a helpful assistant."),
                ChatMessage.FromUser(String.Format("Give me recipe that using {0} with {1} style. Please format for the web.", ingredients, cuisine)),
                },

                MaxTokens = maxTokens
            }); 

            
                if (completionResult.Successful)
                {
                var result = completionResult.Choices.First().Message.Content;
                    payload = result.ToString();
                }
                else
                {
                    payload = String.Format("Code:{0}  Message:{1}",404, completionResult.Error);
            }

 


            return payload;
        }

        private string StripeVerbage(string result)
        {

            int iStart = result.IndexOf("{");
            int iEnd = result.LastIndexOf("}");

            string resonse = result[iStart..(iEnd + 1)];


            return resonse;
        }
    }
}

