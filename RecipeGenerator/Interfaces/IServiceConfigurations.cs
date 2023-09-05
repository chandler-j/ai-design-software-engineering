using System;
using OpenAI.Interfaces;

namespace RecipeGenerator.Interfaces
{
	public interface IServiceConfigurations
    {
        IOpenAIService GetOpenAI();
	}
}

