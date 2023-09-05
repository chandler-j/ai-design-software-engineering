using System;
using OpenAI;
using OpenAI.Interfaces;
using OpenAI.Managers;
using RecipeGenerator.Interfaces;
namespace RecipeGenerator.Services
{
	public class Configurations : IServiceConfigurations

    {
        private readonly IConfiguration _configuration;

        public Configurations(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        private string GetUserSecret()
        {
            return _configuration["OpenAI:ServiceApiKey"];
              
        }

        public IOpenAIService GetOpenAI()
        {

            IOpenAIService openAiService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = GetUserSecret()
            });

            openAiService.SetDefaultModelId(OpenAI.ObjectModels.Models.ChatGpt3_5Turbo0301);
            return openAiService;
        }

        
        
    }
}

